using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using WindowsFormsApp2.usuariosTableAdapters;


namespace WindowsFormsApp2
{
    public partial class Administrador : Form
    {
        string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        BDoracle db = new BDoracle();

        public Administrador()
        {
            InitializeComponent();
            db.conectar();

        }

        private void CenterToolStripButtons()
        {
            int totalButtonWidth = 0;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton)
                {
                    totalButtonWidth += item.Width;
                }
            }

            int padding = (toolStrip1.Width - totalButtonWidth) / 2;
            if (padding > 0)
            {
                toolStrip1.Padding = new Padding(padding, toolStrip1.Padding.Top, toolStrip1.Padding.Right, toolStrip1.Padding.Bottom);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CenterToolStripButtons();
        }


        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientess.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter1.Fill(this.clientess.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'cliente.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.cliente.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'mesas.MESA' Puede moverla o quitarla según sea necesario.
            this.mESATableAdapter.Fill(this.mesas.MESA);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORTableAdapter.Fill(this.dataSet2.PROVEEDOR);
            // TODO: esta línea de código carga datos en la tabla 'productos.INVENTARIO' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'usuarios.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.usuarios.USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'roles.ROLES' Puede moverla o quitarla según sea necesario.
            this.rOLESTableAdapter2.Fill(this.roles.ROLES);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.ROLES' Puede moverla o quitarla según sea necesario.
            this.rOLESTableAdapter.Fill(this.dataSet1.ROLES);
            CenterToolStripButtons();
            tabControlUsuarios.Appearance = TabAppearance.FlatButtons;
            tabControlUsuarios.ItemSize = new Size(0, 1);
            tabControlUsuarios.SizeMode = TabSizeMode.Fixed;
            ConfigurarDataGridView();
            LlenarDataGridView3();
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(btnEliminar);
            dataGridView3.CellClick += new DataGridViewCellEventHandler(dataGridView3_CellClick);
            dataGridView3.Columns["DESCRIPCION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView3.Columns["STOCK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView3.Columns["PRECIO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView3.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;






        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            CenterToolStripButtons();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 1;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 2;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 3;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 3;
        }

        private void tabPageReportes_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void sdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 5;
        }

        private void sdsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 4;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sdsdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 6;
        }

        private void sdsdToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 7;
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 8;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rOLESTableAdapter.FillBy(this.dataSet1.ROLES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idRolSeleccionado = Convert.ToInt32(comboBoxRoles.SelectedValue);

                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO USUARIO (NOMBRE, EMAIL, CONTRASENA, ID_ROLES) VALUES (:nombre, :email, :contrasena, :idRol)", conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("nombre", textBoxNombreUsuario.Text));
                        cmd.Parameters.Add(new OracleParameter("email", textBoxEmail.Text));
                        cmd.Parameters.Add(new OracleParameter("contrasena", textBoxContrasena.Text));
                        cmd.Parameters.Add(new OracleParameter("idRol", idRolSeleccionado));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario agregado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }
            try
            {
                this.uSUARIOTableAdapter.Fill(this.usuarios.USUARIO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar los datos: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.uSUARIOTableAdapter.Fill(this.usuarios.USUARIO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar los datos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EliminarUsuario(int idUsuario)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM USUARIO WHERE ID_USUARIO = :idUsuario", conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("idUsuario", idUsuario));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuario eliminado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTOTableAdapter.FillBy(this.productos.PRODUCTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.pROVEEDORTableAdapter1.FillBy(this.productos.PROVEEDOR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Eliminar"].Index) return;

            // Obtener el ID del usuario de la fila seleccionada
            int usuarioId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_USUARIO"].Value);

            // Confirmar eliminación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Eliminar usuario de la base de datos
                EliminarUsuario(usuarioId);

                // Actualizar DataGridView 
                // LlenarDataGridView3(); 
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigurarDataGridView()
        {

        }

        private void LlenarDataGridView3()
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();

                    string query = @"SELECT p.NOMBRE, p.PRECIO, p.DESCRIPCION, pr.NOMBRE AS PROVEEDOR, p.STOCK , p.ID_PRODUCTO
                     FROM producto p 
                     JOIN proveedor pr ON p.ID_PROVEEDOR = pr.ID_PROVEEDOR";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView3.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void tabPageProductos_Click(object sender, EventArgs e)
        {

        }
        private void InsertarProducto()
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();

                    // Insertar producto con stock inicial (por ejemplo, 0)
                    // Insertar producto con el stock especificado en el textBoxStock
                    string query = "INSERT INTO producto (ID_PROVEEDOR, NOMBRE, PRECIO, DESCRIPCION, STOCK, STOCK_MINIMO) VALUES (:idProveedor, :nombre, :precio, :descripcion, :stock, :stock_minimo)";

                    using (OracleCommand cmd = new OracleCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("idProveedor", Convert.ToInt32(comboBoxPro.SelectedValue)));
                        cmd.Parameters.Add(new OracleParameter("nombre", textBoxNP.Text));
                        cmd.Parameters.Add(new OracleParameter("precio", Convert.ToDecimal(textBoxPrecio.Text)));
                        cmd.Parameters.Add(new OracleParameter("descripcion", textBoxDescripcion.Text));
                        cmd.Parameters.Add(new OracleParameter("stock", Convert.ToInt32(textBoxStock.Text)));
                        cmd.Parameters.Add(new OracleParameter("stock minimo", Convert.ToInt32(textBoxStockMinimo.Text)));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto insertado con éxito.");
                    LlenarDataGridView3();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            InsertarProducto();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            InsertarProducto();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStock_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView3.Columns["Eliminar"].Index) return;

            // Obtener el ID del producto de la fila seleccionada
            int productoId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["ID_PRODUCTO"].Value);

            // Confirmar eliminación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Eliminar producto de la base de datos
                EliminarProducto(productoId);

                // Actualizar DataGridView
                LlenarDataGridView3();
            }
        }


        private void EliminarProducto(int id)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();

                    string query = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO = :idProducto";

                    using (OracleCommand cmd = new OracleCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("idProducto", id));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto eliminado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void tabPageUsuario_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int num_mesa = int.Parse(txtNumMesa.Text);
                int capacidad = int.Parse(txtCapacidad1.Text);
                string descripcion = txtDesc.Text;
                string estado = txtEstado.Text;

                BDoracle bd = new BDoracle();
                bd.AgregarMesa(num_mesa, capacidad, descripcion, estado);

                MessageBox.Show("Mesa agregada con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar el DataGridView
                this.mESATableAdapter.Fill(this.mesas.MESA); 
                dataGridView4.DataSource = mESABindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al agregar la mesa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPageMesas_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView4.Columns["Borrar"].Index) return;

          
            int mesaId = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["ID_MESA"].Value);

            // Confirmar eliminación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta mesa?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Eliminar usuario de la base de datos
                EliminarMesa(mesaId);

                this.mESATableAdapter.Fill(this.mesas.MESA);


            }
        }
        private void EliminarMesa(int mesaId)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM MESA WHERE ID_MESA = :mesaId", conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("mesaId", mesaId));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("MESA eliminado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 11;
        }

        private void textBoxNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {
        
                // Cuando se selecciona un elemento en el ComboBox, carga los datos correspondientes en los TextBox
                if (comboBoxCliente.SelectedIndex >= 0)
                {
                    object selectedValue = comboBoxCliente.SelectedValue;

                    string query = "SELECT NOMBRE_CLI, APELLIDO_CLI, EMAIL, TELEFONO FROM CLIENTE WHERE ID_CLIENTE = :ID_CLIENTE";
                    OracleCommand command = new OracleCommand(query, db.Conectar());
                    command.Parameters.Add(":ID_CLIENTE", OracleDbType.Int32).Value = selectedValue;

                    try
                    {

                        OracleDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textBoxNC.Text = reader["NOMBRE_CLI"].ToString();
                            textBoxAC.Text = reader["APELLIDO_CLI"].ToString();
                            textBoxEC.Text = reader["EMAIL"].ToString();
                            textBoxTC.Text = reader["TELEFONO"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }

                }
            
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedIndex >= 0)
            {
                object selectedValue = comboBoxCliente.SelectedValue;

                string nuevoNombre = textBoxNC.Text;         
                string nuevoApellido = textBoxAC.Text;       
                string nuevoEmail = textBoxEC.Text;         
                string nuevoTelefono = textBoxTC.Text;       

                // Actualizar datos en Oracle
                string query = "UPDATE CLIENTE SET NOMBRE_CLI = :NOMBRE_CLI, APELLIDO_CLI = :APELLIDO_CLI, EMAIL = :EMAIL, TELEFONO = :TELEFONO WHERE ID_CLIENTE = :ID_CLIENTE";
                OracleCommand command = new OracleCommand(query, db.Conectar());
                command.Parameters.Add(":NOMBRE_CLI", OracleDbType.Varchar2).Value = nuevoNombre;
                command.Parameters.Add(":APELLIDO_CLI", OracleDbType.Varchar2).Value = nuevoApellido;
                command.Parameters.Add(":EMAIL", OracleDbType.Varchar2).Value = nuevoEmail;
                command.Parameters.Add(":TELEFONO", OracleDbType.Varchar2).Value = nuevoTelefono;
                command.Parameters.Add(":ID_CLIENTE", OracleDbType.Int32).Value = selectedValue;

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Los datos se han modificado correctamente.");

                        try
                        {
                            this.cLIENTETableAdapter.Fill(this.cliente.CLIENTE);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al refrescar los datos: " + ex.Message);
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

        private void button8_Click(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            tabControlUsuarios.SelectedIndex = 9;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = textBoxNC1.Text;
            string apellido = textBoxAC1.Text;
            string telefono = textBoxTC1.Text;
            string email = textBoxEC1.Text;

            try
            {
                // Conectar a la base de datos
                using (OracleConnection connection = db.Conectar())
                {
                    // Obtener el máximo ID actual y agregarle 1
                    string queryMaxId = "SELECT NVL(MAX(ID_CLIENTE), 0) + 1 FROM CLIENTE";
                    OracleCommand cmdMaxId = new OracleCommand(queryMaxId, connection);
                    int nextId = Convert.ToInt32(cmdMaxId.ExecuteScalar());

                    // Insertar el nuevo cliente
                    string queryInsert = "INSERT INTO CLIENTE (ID_CLIENTE, NOMBRE_CLI, APELLIDO_CLI, TELEFONO, EMAIL) VALUES (:ID, :NOMBRE, :APELLIDO, :TELEFONO, :EMAIL)";
                    OracleCommand cmdInsert = new OracleCommand(queryInsert, connection);
                    cmdInsert.Parameters.Add(":ID", OracleDbType.Int32).Value = nextId;
                    cmdInsert.Parameters.Add(":NOMBRE", OracleDbType.Varchar2).Value = nombre;
                    cmdInsert.Parameters.Add(":APELLIDO", OracleDbType.Varchar2).Value = apellido;
                    cmdInsert.Parameters.Add(":TELEFONO", OracleDbType.Varchar2).Value = telefono;
                    cmdInsert.Parameters.Add(":EMAIL", OracleDbType.Varchar2).Value = email;

                    int rowsAffected = cmdInsert.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        this.cLIENTETableAdapter.Fill(this.cliente.CLIENTE);

                        MessageBox.Show("Cliente agregado correctamente.");

                        this.cLIENTETableAdapter1.Fill(this.clientess.CLIENTE);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el cliente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

  

        private void EliminarCliente1(int idCliente)
        {
            try
            {
                using (OracleConnection conexion = new OracleConnection(conexionString))
                {
                    conexion.Open();
                    using (OracleCommand cmd = new OracleCommand("DELETE FROM CLIENTE WHERE ID_CLIENTE = :idCliente", conexion))
                    {
                        cmd.Parameters.Add(new OracleParameter("idCliente", idCliente));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuario eliminado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStockMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView7.Columns["BorrarCliente"].Index) return;

            int idCliente = Convert.ToInt32(dataGridView7.Rows[e.RowIndex].Cells["ID_CLIENTE1"].Value);

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                EliminarCliente1(idCliente);
                this.cLIENTETableAdapter1.Fill(this.clientess.CLIENTE);
            }

        }
    }


}
    

