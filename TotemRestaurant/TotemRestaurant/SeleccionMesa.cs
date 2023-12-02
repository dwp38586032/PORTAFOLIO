using System;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TotemRestaurant
{
    public partial class SeleccionMesa : Form
    {
        BDoracle db = new BDoracle();
        OracleConnection connection;

        public SeleccionMesa()
        {
            InitializeComponent();
            connection = db.GetOracleConnection();
        }

        private void SeleccionMesa_Load(object sender, EventArgs e)
        {
            CargarMesasDisponibles();
        }

        private void CargarMesasDisponibles()
        {
            try
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand("SELECT NUM_MESA, CAPACIDAD, ESTADO, DESCRIPCION FROM MESA WHERE ESTADO = 'Disponible'", connection))
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int numMesa = reader.GetInt32(0);
                        int capacidad = reader.GetInt32(1);
                        string estado = reader.GetString(2);
                        string descripcion = reader.GetString(3);

                        MesaControl mesaControl = new MesaControl(numMesa, capacidad, estado, descripcion, connection);
                        flowLayoutPanel1.Controls.Add(mesaControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las mesas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Este método parece que estaba vacío en tu código original. Si necesitas agregar algo aquí, hazlo.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Este método también estaba vacío en tu código original. Si este botón tiene una funcionalidad específica, deberás agregarla aquí.
        }
    }
}
