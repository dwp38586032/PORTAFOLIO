using System;
using System.Windows.Forms;
using System.Drawing;
using Oracle.DataAccess.Client;

public class MesaControl : UserControl
{
    public int NumMesa { get; set; }
    public string NombreMesa { get; set; }
    public int Capacidad { get; set; }
    public string Estado { get; set; }
    public string Descripcion { get; set; }

    private OracleConnection connection;

    public event EventHandler MesaClicked;

    public MesaControl(int numMesa, int capacidad, string estado, string descripcion, OracleConnection conn)
    {
        InitializeComponent();

        NumMesa = numMesa;
        NombreMesa = "Número de Mesa: " + numMesa;
        Capacidad = capacidad;
        Estado = estado;
        Descripcion = descripcion;
        connection = conn;

        AgregarControlesDeEtiqueta();

        this.Click += MesaControl_Click;
    }

    private void MesaControl_Click(object sender, EventArgs e)
    {
        try
        {
            using (OracleCommand cmd = new OracleCommand("UPDATE MESA SET ESTADO = 'Ocupado' WHERE NUM_MESA = :numMesa", connection))
            {
                cmd.Parameters.Add(new OracleParameter("numMesa", this.NumMesa));
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No se pudo actualizar la mesa. Verifique si el número de mesa es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Estado = "Ocupado";
                    MessageBox.Show("Numero de mesa imprimido. Acerquese a algún garzón para guíarlo a la mesa correspondiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar el estado de la mesa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void InitializeComponent()
    {
        this.Size = new Size(130, 120);
        this.BackColor = Color.LightBlue;
        this.BorderStyle = BorderStyle.FixedSingle;
    }

    private void AgregarControlesDeEtiqueta()
    {
        this.Controls.Clear();  // Limpiar controles existentes

        Label labelDescripcion = new Label();
        labelDescripcion.Text = "Descripción: " + Descripcion;
        labelDescripcion.Font = new Font("Arial", 8);
        labelDescripcion.Dock = DockStyle.Fill;
        labelDescripcion.TextAlign = ContentAlignment.MiddleCenter;
        labelDescripcion.Click += MesaControl_Click;  // Agregar manejador de evento
        this.Controls.Add(labelDescripcion);

        Label labelCapacidad = new Label();
        labelCapacidad.Text = "Capacidad: " + Capacidad + " personas";
        labelCapacidad.Font = new Font("Arial", 8);
        labelCapacidad.Dock = DockStyle.Top;
        labelCapacidad.TextAlign = ContentAlignment.MiddleCenter;
        labelCapacidad.Click += MesaControl_Click;  // Agregar manejador de evento
        this.Controls.Add(labelCapacidad);

        Label labelEstado = new Label();
        labelEstado.Text = "Estado: " + Estado;
        labelEstado.Font = new Font("Arial", 8);
        labelEstado.Dock = DockStyle.Top;
        labelEstado.TextAlign = ContentAlignment.MiddleCenter;
        labelEstado.Click += MesaControl_Click;  // Agregar manejador de evento
        this.Controls.Add(labelEstado);

        Label labelNumeroMesa = new Label();
        labelNumeroMesa.Text = NombreMesa;
        labelNumeroMesa.Font = new Font("Arial", 8);
        labelNumeroMesa.Dock = DockStyle.Top;
        labelNumeroMesa.TextAlign = ContentAlignment.MiddleCenter;
        labelNumeroMesa.Click += MesaControl_Click;  // Agregar manejador de evento
        this.Controls.Add(labelNumeroMesa);
    }

}
