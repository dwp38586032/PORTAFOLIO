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

namespace Bodega
{
    public partial class Form1 : Form
    {
        BDoracle db = new BDoracle();
        public Form1()
        {
            InitializeComponent();
            db.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            int? roleId = db.ValidarUsuario(email, password);

            if (roleId.HasValue) // Si roleId no es null, significa que el inicio de sesión fue exitoso.
            {
                switch (roleId.Value)
                {
                    case 2:
                        MessageBox.Show("Inicio de sesión exitoso como Finanzas!");

                        this.Hide();
                        Finanzas finanzasForm = new Finanzas();
                        finanzasForm.ShowDialog();
                        this.Show();
                        break;

                    case 3:
                        MessageBox.Show("Inicio de sesión exitoso como Bodega!");

                        this.Hide();
                        Bodeguero bodegaForm = new Bodeguero(); // Suponiendo que tienes una clase llamada Bodega para este formulario.
                        bodegaForm.ShowDialog();
                        this.Show();
                        break;

                    default:
                        MessageBox.Show("Rol no reconocido.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos.");
            }
        }

    }

}
