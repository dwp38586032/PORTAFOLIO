using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;


namespace Bodega
{
    public partial class Bodeguero : Form
    {
        BDoracle db = new BDoracle();
        private OracleConnection connection;
        private OracleDataAdapter adapter;
        private OracleCommandBuilder builder;
        public Bodeguero()
        {
            InitializeComponent();
            db.conectar();

        }

        private void Bodeguero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'receta.RECETA' Puede moverla o quitarla según sea necesario.
            this.rECETATableAdapter.Fill(this.receta.RECETA);
            // TODO: esta línea de código carga datos en la tabla 'solicitud.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter3.Fill(this.solicitud.SOLICITUD);
            // TODO: esta línea de código carga datos en la tabla 'solicitudess.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter2.Fill(this.solicitudess.SOLICITUD);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter1.Fill(this.dataSet1.SOLICITUD);
            // TODO: esta línea de código carga datos en la tabla 'sOLITUDES.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter.Fill(this.sOLITUDES.SOLICITUD);
            // TODO: esta línea de código carga datos en la tabla 'productos.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.productos.PRODUCTO);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            CargarProductos();
            /////////////////////////////////////////////////////////



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {



            tabControl1.SelectedTab = tabPage2;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxProductos.SelectedIndex >= 0)
            {
                object selectedValue = comboBoxProductos.SelectedValue;

                
                string query = "SELECT STOCK, PRECIO FROM PRODUCTO WHERE ID_PRODUCTO = :ID_PRODUCTO";
                OracleCommand command = new OracleCommand(query, db.Conectar());
                command.Parameters.Add(":ID_PRODUCTO", OracleDbType.Int32).Value = selectedValue;

                try
                {

                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxCantidad.Text = reader["STOCK"].ToString();
                        textBoxPrecio.Text = reader["PRECIO"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }

            }
        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Cuando se presiona el botón Modificar, actualiza los datos en Oracle
            if (comboBoxProductos.SelectedIndex >= 0)
            {
                object selectedValue = comboBoxProductos.SelectedValue;
                int nuevaCantidad = int.Parse(textBoxCantidad.Text);
                decimal nuevoPrecio = decimal.Parse(textBoxPrecio.Text);

                // Actualiza los datos en Oracle
                string query = "UPDATE PRODUCTO SET STOCK = :STOCK, PRECIO = :PRECIO WHERE ID_PRODUCTO = :ID_PRODUCTO";
                OracleCommand command = new OracleCommand(query, db.Conectar());
                command.Parameters.Add(":STOCK", OracleDbType.Int32).Value = nuevaCantidad;
                command.Parameters.Add(":PRECIO", OracleDbType.Decimal).Value = nuevoPrecio;
                command.Parameters.Add(":ID_PRODUCTO", OracleDbType.Int32).Value = selectedValue;

                try
                {

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Los datos se han modificado correctamente.");
                        {
                            try
                            {

                                this.pRODUCTOTableAdapter.Fill(this.productos.PRODUCTO);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al refrescar los datos: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se han realizado cambios.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxP.SelectedIndex >= 0)
            {
                object selectedValue = comboBoxP.SelectedValue;
                string cantidad = textBoxCan.Text;
                string descripcion = textBoxDescri.Text;
                string estado = "pendiente";
                int idProveedor = ObtenerIdProveedorDeProducto(selectedValue); // Obtener el id_proveedor del producto seleccionado

                string query = "INSERT INTO SOLICITUD (ID_PRODUCTO, CANTIDAD, ESTADO, DESCRIPCION, ID_PROVEEDOR) " +
                               "VALUES (:ID_PRODUCTO, :CANTIDAD, :ESTADO, :DESCRIPCION, :ID_PROVEEDOR)";
                OracleCommand command = new OracleCommand(query, db.Conectar());

                command.Parameters.Add(":ID_PRODUCTO", OracleDbType.Int32).Value = selectedValue;
                command.Parameters.Add(":CANTIDAD", OracleDbType.Varchar2).Value = cantidad;
                command.Parameters.Add(":ESTADO", OracleDbType.Varchar2).Value = estado;
                command.Parameters.Add(":DESCRIPCION", OracleDbType.Varchar2).Value = descripcion;
                command.Parameters.Add(":ID_PROVEEDOR", OracleDbType.Int32).Value = idProveedor; // Agregar el id_proveedor

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("La solicitud se ha ingresado correctamente.");
                        
                        comboBoxP.SelectedIndex = -1;
                        textBoxCan.Clear();
                        textBoxDescri.Clear();

                        try
                        {
                            this.sOLICITUDTableAdapter3.Fill(this.solicitud.SOLICITUD);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al refrescar los datos: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha realizado la solicitud.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar la solicitud: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto.");
            }
        }
        private int ObtenerIdProveedorDeProducto(object productoId)
        {

            using (OracleConnection connection = db.Conectar())
            {
                string query = "SELECT ID_PROVEEDOR FROM PRODUCTO WHERE ID_PRODUCTO = :ID_PRODUCTO";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":ID_PRODUCTO", OracleDbType.Int32).Value = productoId;

                try
                {

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        
                        throw new Exception("El producto seleccionado no tiene un id_proveedor válido.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones en caso de error en la consulta.
                    throw new Exception("Error al obtener el id_proveedor del producto: " + ex.Message);
                }
            }
        }
        private void EliminarSolicitud(int idSolicitud)
        {
            try
            {
                using (OracleConnection connection = db.Conectar()) 
                {
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM SOLICITUD WHERE ID_SOLICITUD = :idSolicitud", connection))
                    {
                        cmd.Parameters.Add(":idSolicitud", OracleDbType.Int32).Value = idSolicitud;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Solicitud eliminada con éxito.");
                            this.sOLICITUDTableAdapter3.Fill(this.solicitud.SOLICITUD);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna solicitud con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la solicitud: " + ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que el clic fue en la columna del botón de eliminar y no en el encabezado
            if (e.RowIndex >= 0 && dataGridViewSolicitudes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Obtener el ID de la solicitud de la fila seleccionada
                int solicitudId = Convert.ToInt32(dataGridViewSolicitudes.Rows[e.RowIndex].Cells["ID_SOLICITUD"].Value);

                // Confirmar eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta solicitud?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar solicitud de la base de datos
                    EliminarSolicitud(solicitudId);

                    // Actualizar DataGridView
                    // LlenarDataGridViewSolicitudes(); 
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarProductos()
        {
            checkedListBoxIR.Items.Clear(); // Limpiar ítems antes de añadir nuevos.

            try
            {
                using (OracleConnection connection = db.Conectar()) 
                {
                    using (OracleCommand cmd = new OracleCommand("SELECT NOMBRE FROM PRODUCTO", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                checkedListBoxIR.Items.Add(reader["NOMBRE"].ToString());
                                checkedListBoxIR2.Items.Add(reader["NOMBRE"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string nombreReceta = textBoxNR.Text;
                string instruccionesReceta = textBoxINR.Text;

                // Recolecta los ingredientes seleccionados en el CheckedListBoxIR
                List<string> ingredientesSeleccionados = new List<string>();
                foreach (object itemChecked in checkedListBoxIR.CheckedItems)
                {
                    ingredientesSeleccionados.Add(itemChecked.ToString());
                }

                // Conecta a la base de datos
                using (OracleConnection connection = db.Conectar()) 
                {
                    try
                    {
                        // Inserta los datos en la tabla "receta"
                        using (OracleCommand cmd = new OracleCommand("INSERT INTO receta (nombre, instrucciones, ingredientes) VALUES (:nombre, :instrucciones, :ingredientes)", connection))
                        {
                            cmd.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombreReceta;
                            cmd.Parameters.Add(":instrucciones", OracleDbType.Varchar2).Value = instruccionesReceta;
                            cmd.Parameters.Add(":ingredientes", OracleDbType.Varchar2).Value = string.Join(", ", ingredientesSeleccionados);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Receta agregada con éxito.");
                                this.rECETATableAdapter.Fill(this.receta.RECETA);
                        }
                            else
                            {
                                MessageBox.Show("No se pudo agregar la receta.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la receta: " + ex.Message);
                    }
                }
            
        }

        private void comboBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex >= 0)
            {
                object selectedValue = comboBox1.SelectedValue;

                
                string query = "SELECT NOMBRE, INSTRUCCIONES FROM RECETA WHERE ID_RECETA = :ID_RECETA";
                OracleCommand command = new OracleCommand(query, db.Conectar());
                command.Parameters.Add(":ID_RECETA", OracleDbType.Int32).Value = selectedValue;

                try
                {

                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox2.Text = reader["NOMBRE"].ToString();
                        textBox1.Text = reader["INSTRUCCIONES"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                object selectedValue = comboBox1.SelectedValue;

                string nuevoNombre = textBox2.Text;
                string nuevasInstrucciones = textBox1.Text;

                // Obtén los ingredientes seleccionados del checkedListBoxIR2
                List<string> ingredientesSeleccionados = new List<string>();
                foreach (object itemChecked in checkedListBoxIR2.CheckedItems)
                {
                    ingredientesSeleccionados.Add(itemChecked.ToString());
                }

                // Convierte la lista de ingredientes a una cadena separada por comas
                string ingredientes = string.Join(", ", ingredientesSeleccionados);

                // Actualiza los datos en Oracle
                string query = "UPDATE RECETA SET NOMBRE = :NOMBRE, INSTRUCCIONES = :INSTRUCCIONES, INGREDIENTES = :INGREDIENTES WHERE ID_RECETA = :ID_RECETA";
                OracleCommand command = new OracleCommand(query, db.Conectar());
                command.Parameters.Add(":NOMBRE", OracleDbType.Varchar2).Value = nuevoNombre;
                command.Parameters.Add(":INSTRUCCIONES", OracleDbType.Varchar2).Value = nuevasInstrucciones;
                command.Parameters.Add(":INGREDIENTES", OracleDbType.Varchar2).Value = ingredientes;
                command.Parameters.Add(":ID_RECETA", OracleDbType.Int32).Value = selectedValue;

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Los datos de la receta se han modificado correctamente.");

                        this.rECETATableAdapter.Fill(this.receta.RECETA);
                    }
                    else
                    {
                        MessageBox.Show("No se han realizado cambios.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos de la receta: " + ex.Message);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarReceta(int idReceta)
        {
            try
            {
                using (OracleConnection connection = db.Conectar()) 
                {
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM RECETA WHERE ID_RECETA = :idReceta", connection))
                    {
                        cmd.Parameters.Add(":idReceta", OracleDbType.Int32).Value = idReceta;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Receta eliminada con éxito.");
                            // Actualiza el DataGridView de recetas
                            // LlenarDataGridViewRecetas(); 
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna receta con el ID especificado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la receta: " + ex.Message);
            }
        }

        private void dataGridViewSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && dataGridView3.Columns[e.ColumnIndex].Name == "BorrarReceta")
            {
                
                int recetaId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["ID_RECETA"].Value);

                // Confirmar eliminación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta receta?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar la receta de la base de datos
                    EliminarReceta(recetaId);

                    // Actualizar DataGridView
                    // LlenarDataGridViewRecetas(); 
                }
            }
        }
    }
}
