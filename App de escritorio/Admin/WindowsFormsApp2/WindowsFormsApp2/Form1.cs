using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp2
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

            if (db.ValidarUsuario(email, password))
            {
                MessageBox.Show("Inicio de sesión exitoso!");
          
                this.Hide();
                Administrador adminForm = new Administrador();
                adminForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtEmail.Text = "nombre@correo.com";
            txtEmail.ForeColor = Color.Gray;
        }
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "nombre@correo.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text = "nombre@correo.com";
                txtEmail.ForeColor = Color.Gray;
            }
        }

    }
}
