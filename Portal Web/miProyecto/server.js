const express = require('express');
const bodyParser = require('body-parser');
const oracledb = require('oracledb');
const app = express();
const moment = require('moment');
const nodemailer = require('nodemailer');

// Parsear el cuerpo de las solicitudes POST
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

let pool;
//CONFIGURACIÓN ORALCE
async function iniciarConexion() {
    pool = await oracledb.createPool({
        user: 'C##Admin_restaurantXXI',
        password: 'oracle',
        connectString: 'localhost/XE' 
    });
}

iniciarConexion();
app.get('/', (req, res) => {
    res.sendFile(__dirname + '/index.html');
});

// Configuración de nodemailer con credenciales SMTP
const transporter = nodemailer.createTransport({
    host: 'smtp.gmail.com', // servidor SMTP
    port: 587,
    secure: false, // true para 465, false para otros puertos
    auth: {
        user: 'contacto.restaurantexxi@gmail.com', 
        pass: 'kxlo mvld qocc zftt' 
    }
});

// Endpoint para obtener datos
app.get('/obtener-datos', async (req, res) => {
    let conexion;
    try {
        conexion = await pool.getConnection();
        const result = await conexion.execute('SELECT * FROM ROLES');
        res.json(result.rows);
    } catch (err) {
        console.error(err);
        res.status(500).json({ error: 'Hubo un error al obtener los datos.' });
    } finally {
        if (conexion) {
            conexion.close();
        }
    }
});

// REALIZAR RESERVA
app.post('/realizar-reserva', async (req, res) => {
    const { name, lastName, email, phoneNumber, date, time, capacity, tableNumber } = req.body;
    const formattedDate = moment(date).format('DD-MM-YYYY');
    const formattedTime = moment(time, 'HH:mm').format('HH:mm'); // Formato de 24 horas
    //const numMesa = req.body.numMesa;

    let conexion;
    try {
        conexion = await pool.getConnection();
        // Insertar datos del cliente en la tabla CLIENTE
        const insertClienteSql = `
            INSERT INTO CLIENTE (NOMBRE_CLI, APELLIDO_CLI, EMAIL, TELEFONO) 
            VALUES (:name, :lastName, :email, :phoneNumber) RETURNING ID_CLIENTE INTO :idCliente
        `;
        const resultCliente = await conexion.execute(
            insertClienteSql,
            { name, lastName, email, phoneNumber, idCliente: { dir: oracledb.BIND_OUT, type: oracledb.NUMBER } },
            { autoCommit: false }
        );        
        // Realizar un commit explícito
        await conexion.commit();
        const idCliente = resultCliente.outBinds.idCliente[0];

        // Seleccionar la mesa basada en la capacidad
            const selectMesaSql = `
                SELECT ID_MESA FROM MESA 
                WHERE CAPACIDAD >= :capacity AND ESTADO = 'Disponible'
                ORDER BY CAPACIDAD ASC
                FETCH FIRST ROW ONLY
            `;
            const resultMesa = await conexion.execute(selectMesaSql, [capacity], { outFormat: oracledb.OUT_FORMAT_OBJECT });
            if (resultMesa.rows.length === 0) {
                throw new Error('No hay mesas disponibles para la capacidad solicitada.');
            }
            const mesa = resultMesa.rows[0];
            // Consultar el código de reserva
            const selectCodigoSql = `
            SELECT CODIGO FROM RESERVA
            WHERE NUM_MESA = :tableNumber
            AND FECHA = TO_DATE(:fecha, 'DD/MM/YYYY')
            AND HORA = :hora
            AND ESTADO_RESERVA = 'Disponible'
             `;

             const resultadoCodigo = await conexion.execute(selectCodigoSql, {
                tableNumber,         
                fecha: formattedDate, 
                hora: formattedTime   
            }, { outFormat: oracledb.OUT_FORMAT_OBJECT });
            
        
        if (resultadoCodigo.rows.length === 0) {
            throw new Error('No se encontró la reserva con los datos proporcionados.');
        }

        const codigo = resultadoCodigo.rows[0].CODIGO; // Aquí se obtiene el código de reserva
        
        // Actualizar la reserva para cambiar el estado a 'Confirmada'
        const updateReservaSql = `
            UPDATE RESERVA
            SET ESTADO_RESERVA = 'Reservado'
            WHERE NUM_MESA = :tableNumber
            AND FECHA = TO_DATE(:fecha, 'DD-MM-YYYY')
            AND HORA = :hora
            AND ESTADO_RESERVA = 'Disponible'
        `;
        
        // Realizar la actualización con los datos necesarios
        const updateResult = await conexion.execute(updateReservaSql, {
            //codigo: codigoReserva,
            tableNumber, 
            fecha: formattedDate,
            hora: formattedTime
        }, { autoCommit: false });
        // Realizar un commit explícito después de la actualización
        await conexion.commit();
        // Verificar si la actualización fue exitosa
        if (updateResult.rowsAffected === 0) {
            throw new Error('No se pudo actualizar la reserva.');
        }
        // INSERTAR RESERVA -- const resultReserva = await conexion.execute(insertReservaSql, binds, { autoCommit: false });
        // Configurar y enviar correo electrónico con el código de reserva
        const mailOptions = {
            from: 'contacto.restaurantexxi@gmail.com',
            to: email,
            subject: 'Confirmación de Reserva',
            text: `Estimado/a ${name}, su reserva ha sido confirmada.\nCódigo de reserva: ${codigo}\nFecha: ${formattedDate}\nHora: ${formattedTime}`
        };

        await transporter.sendMail(mailOptions);

        res.status(200).json({ message: 'Reserva realizada con éxito y correo enviado.', codigo: codigo });
    } catch (err) {
        console.error(err);
        if (conexion) {
            await conexion.rollback();
        }
        res.status(500).json({ error: 'Hubo un error al realizar la reserva.' });
    } finally {
        if (conexion) {
            await conexion.close();
        }
    }
});


// CANCELAR RESERVA
app.post('/cancelar-reserva', async (req, res) => {
    const codigoReserva = req.body.codigoReserva; 
        
    try {
        let conexion = await pool.getConnection();
        const updateQuery = 'UPDATE RESERVA SET ESTADO_RESERVA = :nuevoEstado WHERE CODIGO = :codigoReserva AND ESTADO_RESERVA = \'Confirmada\'';
        const resultado = await conexion.execute(updateQuery, { nuevoEstado: 'Cancelado', codigoReserva: codigoReserva }, { autoCommit: true });
        
        if (resultado.rowsAffected === 0) {
            throw new Error('No se encontró la reserva o ya estaba cancelada.');
        }
        
        conexion.close();
        res.status(200).json({ message: 'Reserva cancelada con éxito.' });
    } catch (err) {
        console.error(err);
        res.status(500).json({ error: 'Hubo un error al cancelar la reserva.' });
    }
});

// Horas Disponible
app.get('/verificar-disponibilidad', async (req, res) => {
    let conexion;
    try {
        conexion = await pool.getConnection();
        console.log('Fecha recibida:', req.query.fecha); // Esto mostrará la fecha recibida en el servidor
        const result = await conexion.execute(
            `SELECT DISTINCT HORA FROM RESERVA WHERE FECHA = TO_DATE(:fecha, 'YYYY-MM-DD') AND ESTADO_RESERVA = 'Disponible' ORDER BY HORA`,
            { fecha: req.query.fecha }
        );
        const horasDisponibles = result.rows.map(row => row[0]); 
        console.log('Horas disponibles:', horasDisponibles); // imprimir las horas disponibles en el servidor
        res.json(horasDisponibles); // Envía solo las horas disponibles
    } catch (err) {
        console.error(err);
        res.status(500).json({ error: 'Hubo un error al verificar la disponibilidad.' });
    } finally {
        if (conexion) {
            try {
                await conexion.close();
            } catch (closeErr) {
                console.error('Error al cerrar la conexión:', closeErr);
            }
        }
    }
});

// Capacidad Personas
app.get('/verificar-mesas-disponibles', async (req, res) => {
    let conexion;
    try {
        conexion = await pool.getConnection();
        const cantidadPersonas = req.query.cantidadPersonas;

        const result = await conexion.execute(
            `SELECT NUM_MESA, CAPACIDAD FROM MESA WHERE CAPACIDAD >= :cantidadPersonas AND ESTADO = 'Disponible' ORDER BY CAPACIDAD ASC`,
            [cantidadPersonas]
        );
        
        res.json(result.rows);
    } catch (err) {
        console.error(err);
        res.status(500).json({ error: 'Hubo un error al verificar la disponibilidad de las mesas.' });
    } finally {
        if (conexion) {
            await conexion.close();
        }
    }
});

// Endpoint para obtener las capacidades de las mesas
app.get('/obtener-capacidades-mesas', async (req, res) => {
    let conexion;
    try {
        conexion = await pool.getConnection();
        const result = await conexion.execute(
            `SELECT DISTINCT CAPACIDAD FROM MESA WHERE ESTADO = 'Disponible' ORDER BY CAPACIDAD ASC`
        );
        // Extraer solo las capacidades y enviarlas
        const capacidades = result.rows.map(row => row[0]);
        res.json(capacidades);
    } catch (err) {
        console.error(err);
        res.status(500).json({ error: 'Hubo un error al obtener las capacidades de las mesas.' });
    } finally {
        if (conexion) {
            await conexion.close();
        }
    }
});

// Obtener Mesas Disponibles para reservas
app.get('/obtener-mesas-disponibles', async (req, res) => {
    let conexion;
    try {
        conexion = await pool.getConnection();
        const result = await conexion.execute(
            `SELECT DISTINCT NUM_MESA FROM RESERVA WHERE ESTADO_RESERVA = 'Disponible' ORDER BY NUM_MESA ASC`,
            [], // No hay parámetros en esta consulta
            { outFormat: oracledb.OUT_FORMAT_OBJECT } // Asegura que el resultado sea un objeto
        );

        // Mapear los resultados para obtener solo los números de mesa
        const mesasDisponibles = result.rows.map(row => row.NUM_MESA);

        res.json(mesasDisponibles);
    } catch (err) {
        console.error('Error al obtener las mesas disponibles: ', err);
        res.status(500).send('Error al obtener las mesas disponibles.');
    } finally {
        if (conexion) {
            conexion.close();
        }
    }
});


app.listen(3000, () => {
    console.log('Servidor corriendo en http://localhost:3000');
});

app.use(express.static('public'));
