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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml.Linq;

namespace Bodega
{
    public partial class Finanzas : Form
    {
        public Finanzas()
        {
            InitializeComponent();
            OcultarPestanasTabControl(tabControl1);
            CargarMesasDisponibles();
        }

        private void Finanzas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ordenPedido.ORDEN_PEDIDO' Puede moverla o quitarla según sea necesario.
            this.oRDEN_PEDIDOTableAdapter1.Fill(this.ordenPedido.ORDEN_PEDIDO);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.ORDEN_PEDIDO' Puede moverla o quitarla según sea necesario.
            this.oRDEN_PEDIDOTableAdapter.Fill(this.dataSet2.ORDEN_PEDIDO);
            // TODO: esta línea de código carga datos en la tabla 'idboletas.BOLETA' Puede moverla o quitarla según sea necesario.
            this.bOLETATableAdapter2.Fill(this.idboletas.BOLETA);
            // TODO: esta línea de código carga datos en la tabla 'boletas.BOLETA' Puede moverla o quitarla según sea necesario.
            this.bOLETATableAdapter1.Fill(this.boletas.BOLETA);
            // TODO: esta línea de código carga datos en la tabla 'emitir.MESA' Puede moverla o quitarla según sea necesario.
            this.mESATableAdapter.Fill(this.emitir.MESA);
            // TODO: esta línea de código carga datos en la tabla 'boleta.BOLETA' Puede moverla o quitarla según sea necesario.
            this.bOLETATableAdapter.Fill(this.boleta.BOLETA);

        }

        private void CargarMesasDisponibles()
        {
 
        }

        private void CargarOrdenesDePedidoPorMesa(string mesa)
        {
            string consultaSQL = "SELECT ID_ORDEN_PEDIDO FROM MESA WHERE ESTADO = 'Ocupado' AND NUM_MESA = :mesa";
            BDoracle bd = new BDoracle();

            using (OracleConnection conexion = bd.Conectar())
            {
                using (OracleCommand cmd = new OracleCommand(consultaSQL, conexion))
                {
                    cmd.Parameters.Add(new OracleParameter("mesa", mesa));

                    try
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            comboBox3.Items.Clear(); // Limpia los items anteriores
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["ID_ORDEN_PEDIDO"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las órdenes de pedido para la mesa seleccionada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string consultaSQL = "";
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            consultaSQL = $"SELECT SUM(MONTO_NETO) AS GANANCIAS FROM BOLETA WHERE FECHA BETWEEN TO_DATE('{fechaInicio:dd/MM/yyyy} 00:00:00', 'dd/MM/yyyy HH24:MI:SS') AND TO_DATE('{fechaFin:dd/MM/yyyy} 23:59:59', 'dd/MM/yyyy HH24:MI:SS')";


            BDoracle bd = new BDoracle();
            using (OracleConnection conexion = bd.Conectar())
            {
                using (OracleCommand cmd = new OracleCommand(consultaSQL, conexion))
                {
                    object result = cmd.ExecuteScalar();
                    decimal ganancias = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    txtGananciasTotales.Text = ganancias.ToString("C0"); // Mostrar como moneda.

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        public static void OcultarPestanasTabControl(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox3.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un número de orden de pedido.");
                return;
            }

            
            long ordenPedidoSeleccionada;
            try
            {
                ordenPedidoSeleccionada = Convert.ToInt64(comboBox3.SelectedValue);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("El número de orden de pedido seleccionado no es válido.");
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del número de orden de pedido seleccionado no es válido.");
                return;
            }

            
            string consultaBoleta = "SELECT BOLETA.* " +
                                    "FROM BOLETA " +
                                    "JOIN ORDEN_PEDIDO ON BOLETA.ID_BOLETA = ORDEN_PEDIDO.ID_BOLETA " +
                                    "WHERE ORDEN_PEDIDO.ID_ORDEN_PEDIDO = :orden";
            
        

        BDoracle bd = new BDoracle();

            using (OracleConnection conexion = bd.Conectar())
            {
                using (OracleCommand cmd = new OracleCommand(consultaBoleta, conexion))
                {
                    
                    cmd.Parameters.Add(new OracleParameter("orden", ordenPedidoSeleccionada));

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable boletasTable = new DataTable();
                        adapter.Fill(boletasTable);

                        // Verificar si se encontraron datos
                        if (boletasTable.Rows.Count > 0)
                        {
                            // Crear un documento PDF
                            Document doc = new Document();
                            string pdfPath = "Boleta.pdf";
                            PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

                            doc.Open();
                            // Obtener los datos de la boleta
                            string numeroBoleta = boletasTable.Rows[0]["ID_BOLETA"].ToString();
                            string fechaBoleta = boletasTable.Rows[0]["FECHA"].ToString();
                            string montoNeto = boletasTable.Rows[0]["MONTO_NETO"].ToString();
                            string iva = boletasTable.Rows[0]["IVA"].ToString();
                            string propina = boletasTable.Rows[0]["PROPINA"].ToString();
                            string montoTotal = boletasTable.Rows[0]["MONTO_TOTAL"].ToString();

                            // títulos, detalles, totales, etc., al PDF
                            doc.Add(new Paragraph("RESTAURANT SIGLO XXI"));
                            doc.Add(new Paragraph("GRACIAS POR SU COMPRA"));
                            doc.Add(Chunk.NEWLINE);
                            // encabezado
                            doc.Add(new Paragraph("BOLETA DE VENTA"));
                            doc.Add(new Paragraph("Número de Boleta: " + numeroBoleta));
                            doc.Add(new Paragraph("Fecha: " + fechaBoleta));
                            doc.Add(Chunk.NEWLINE);
                            doc.Add(new Paragraph("Detalle de la compra:"));

                            // Obtener los platos del pedido seleccionado
                            string consultaPlatos = "SELECT PLATO.NOMBRE, PLATO.PRECIO FROM DETALLE_ORDEN JOIN PLATO ON DETALLE_ORDEN.ID_PLATO = PLATO.ID_PLATO WHERE DETALLE_ORDEN.ID_ORDEN_PEDIDO = :orden";
                            DataTable platosTable = new DataTable();

                            using (OracleCommand platosCmd = new OracleCommand(consultaPlatos, conexion))
                            {
                                platosCmd.Parameters.Add(new OracleParameter("orden", ordenPedidoSeleccionada));

                                using (OracleDataAdapter platosAdapter = new OracleDataAdapter(platosCmd))
                                {
                                    platosAdapter.Fill(platosTable);
                                }
                            }

                            // Verificar si se encontraron platos
                            if (platosTable.Rows.Count > 0)
                            {
                                doc.Add(Chunk.NEWLINE);
                                doc.Add(new Paragraph("Platos del Pedido:"));

                                foreach (DataRow row in platosTable.Rows)
                                {
                                    string nombrePlato = row["NOMBRE"].ToString();
                                    string precioPlato = row["PRECIO"].ToString();

                                    doc.Add(new Paragraph("Nombre del Plato: " + nombrePlato));
                                    //doc.Add(new Paragraph("Precio del Plato: " + precioPlato));
                                    doc.Add(Chunk.NEWLINE);
                                }
                            }

                            // totales
                            doc.Add(new Paragraph("Monto Neto: " + montoNeto));
                            doc.Add(new Paragraph("IVA: " + iva));
                            doc.Add(new Paragraph("Propina: " + propina));
                            doc.Add(new Paragraph("Monto Total: " + montoTotal));
                            // Mensaje de agradecimiento
                            doc.Add(Chunk.NEWLINE);
                            doc.Add(new Paragraph("¡GRACIAS POR ELEGIR RESTAURANT SIGLO XXI!"));
                            // Cerrar el documento PDF
                            doc.Close();

                            // PDF generado en el visor de PDF predeterminado
                            System.Diagnostics.Process.Start(pdfPath);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para la mesa y orden de pedido seleccionadas.");
                        }
                    }
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOLETATableAdapter1.FillBy(this.boletas.BOLETA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}