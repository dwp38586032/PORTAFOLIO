using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TotemRestaurant
{
    public partial class ReservaForm : Form
    {
        public ReservaForm()
        {
            InitializeComponent();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtCodigoReserva.Text;
            BDoracle bd = new BDoracle();

            try
            {
                if (bd.ExisteReserva(codigoIngresado))
                {
                    if (bd.ConfirmarReserva(codigoIngresado))
                    {
                        MessageBox.Show("La reserva ha sido confirmada, diríjase a la mesa correspondiente.", "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo confirmar la reserva.", "Error al Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el código o la reserva no está disponible.", "Reserva No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ReservaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Close();
        }
    }
}
