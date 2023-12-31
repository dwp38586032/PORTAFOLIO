﻿using System;
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
            // TODO: esta línea de código carga datos en la tabla 'emitir.MESA' Puede moverla o quitarla según sea necesario.
            this.mESATableAdapter.Fill(this.emitir.MESA);
            // TODO: esta línea de código carga datos en la tabla 'boleta.BOLETA' Puede moverla o quitarla según sea necesario.
            this.bOLETATableAdapter.Fill(this.boleta.BOLETA);

        }

        private void CargarMesasDisponibles()
        {
            string consultaSQL = "SELECT NUM_MESA FROM MESA WHERE ESTADO = 'Ocupado'";
            BDoracle bd = new BDoracle();

            using (OracleConnection conexion = bd.Conectar())
            {
                using (OracleCommand cmd = new OracleCommand(consultaSQL, conexion))
                {
                    try
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            comboBox1.Items.Clear(); // Limpia los items anteriores
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["NUM_MESA"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las mesas disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                            comboBox2.Items.Clear(); // Limpia los items anteriores
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader["ID_ORDEN_PEDIDO"].ToString());
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
            if (comboBox1.SelectedIndex >= 0)
            {
                // Cuando se selecciona una mesa en comboBox1, cargamos automáticamente las órdenes de pedido para esa mesa.
                string mesaSeleccionada = comboBox1.SelectedItem.ToString();
                CargarOrdenesDePedidoPorMesa(mesaSeleccionada);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la mesa y la orden de pedido seleccionadas
            string mesaSeleccionada = comboBox1.SelectedItem?.ToString();
            string ordenPedidoSeleccionada = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesaSeleccionada) || string.IsNullOrEmpty(ordenPedidoSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una mesa y un número de orden de pedido.");
                return;
            }

            // Consulta para obtener los datos de la boleta desde la base de datos
            string consultaBoleta = "SELECT BOLETA.* " +
                            "FROM BOLETA " +
                            "JOIN MESA ON BOLETA.ID_BOLETA = MESA.ID_BOLETA " +
                            "WHERE MESA.NUM_MESA = :mesa AND MESA.ID_ORDEN_PEDIDO = :orden";
            BDoracle bd = new BDoracle();

            using (OracleConnection conexion = bd.Conectar())
            {
                using (OracleCommand cmd = new OracleCommand(consultaBoleta, conexion))
                {
                    cmd.Parameters.Add(new OracleParameter("mesa", mesaSeleccionada));
                    cmd.Parameters.Add(new OracleParameter("orden", ordenPedidoSeleccionada));

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable boletaTable = new DataTable();
                        adapter.Fill(boletaTable);

                        // Verificar si se encontraron datos
                        if (boletaTable.Rows.Count > 0)
                        {
                            // Crear un documento PDF
                            Document doc = new Document();
                            string pdfPath = "Boleta.pdf";
                            PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

                            doc.Open();
                            // Obtener los datos de la boleta
                            string numeroBoleta = boletaTable.Rows[0]["ID_BOLETA"].ToString();
                            string fechaBoleta = boletaTable.Rows[0]["FECHA"].ToString();
                            string montoNeto = boletaTable.Rows[0]["MONTO_NETO"].ToString();
                            string iva = boletaTable.Rows[0]["IVA"].ToString();
                            string propina = boletaTable.Rows[0]["PROPINA"].ToString();
                            string montoTotal = boletaTable.Rows[0]["MONTO_TOTAL"].ToString();

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
    }
}