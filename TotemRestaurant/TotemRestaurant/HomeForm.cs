using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotemRestaurant
{
    public partial class HomeForm : Form
    {
        BDoracle db = new BDoracle();
        public HomeForm()
        {
            InitializeComponent();
           
            db.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservaForm reservaForm = new ReservaForm();
            reservaForm.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionMesa seleccionMesa = new SeleccionMesa();
            seleccionMesa.ShowDialog();
            this.Close();
        }
    }
}
