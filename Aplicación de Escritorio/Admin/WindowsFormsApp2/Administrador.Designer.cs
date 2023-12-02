using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdsdToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabPageFinanzas = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageBodega = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageReportes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageUsuario = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios = new WindowsFormsApp2.usuarios();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.rOLESBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.roles = new WindowsFormsApp2.roles();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxPro = new System.Windows.Forms.ComboBox();
            this.pROVEEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp2.DataSet2();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageMesas = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesas = new WindowsFormsApp2.Mesas();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCapacidad1 = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageRecetas = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nOMBRECLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente = new WindowsFormsApp2.Cliente();
            this.label25 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxEC = new System.Windows.Forms.TextBox();
            this.textBoxAC = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxNC = new System.Windows.Forms.TextBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBoxEC1 = new System.Windows.Forms.TextBox();
            this.textBoxTC1 = new System.Windows.Forms.TextBox();
            this.textBoxAC1 = new System.Windows.Forms.TextBox();
            this.textBoxNC1 = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.nOMBRECLIDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOCLIDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.productos = new WindowsFormsApp2.Productos();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp2.DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rOLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOLESTableAdapter = new WindowsFormsApp2.DataSet1TableAdapters.ROLESTableAdapter();
            this.rOLESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter1 = new WindowsFormsApp2.DataSet1TableAdapters.ROLESTableAdapter();
            this.rOLESBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rOLESTableAdapter2 = new WindowsFormsApp2.rolesTableAdapters.ROLESTableAdapter();
            this.uSUARIOTableAdapter = new WindowsFormsApp2.usuariosTableAdapters.USUARIOTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEEDORTableAdapter = new WindowsFormsApp2.DataSet2TableAdapters.PROVEEDORTableAdapter();
            this.pRODUCTOTableAdapter = new WindowsFormsApp2.ProductosTableAdapters.PRODUCTOTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.ProductosTableAdapters.TableAdapterManager();
            this.fKPRODUCTOREFERENCEINVENTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVEEDORTableAdapter1 = new WindowsFormsApp2.ProductosTableAdapters.PROVEEDORTableAdapter();
            this.mESATableAdapter = new WindowsFormsApp2.MesasTableAdapters.MESATableAdapter();
            this.cLIENTETableAdapter = new WindowsFormsApp2.ClienteTableAdapters.CLIENTETableAdapter();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.clientess = new WindowsFormsApp2.Clientess();
            this.cLIENTEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter1 = new WindowsFormsApp2.ClientessTableAdapters.CLIENTETableAdapter();
            this.ID_CLIENTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECLIDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOCLIDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPACIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControlUsuarios.SuspendLayout();
            this.tabPageFinanzas.SuspendLayout();
            this.tabPageBodega.SuspendLayout();
            this.tabPageMantenimiento.SuspendLayout();
            this.tabPageReportes.SuspendLayout();
            this.tabPageUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).BeginInit();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.tabPageMesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPageRecetas.SuspendLayout();
            this.tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTOREFERENCEINVENTARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator6,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1332, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 34);
            this.toolStripButton1.Text = "Finanzas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(92, 34);
            this.toolStripButton4.Text = "Bodega";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(103, 34);
            this.toolStripButton3.Text = "Reportes";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdsdToolStripMenuItem,
            this.sdsToolStripMenuItem,
            this.sdsdToolStripMenuItem1,
            this.sdsdToolStripMenuItem2,
            this.recetasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(173, 34);
            this.toolStripDropDownButton1.Text = "Mantenimiento";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // sdsdToolStripMenuItem
            // 
            this.sdsdToolStripMenuItem.Name = "sdsdToolStripMenuItem";
            this.sdsdToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.sdsdToolStripMenuItem.Text = "Usuarios";
            this.sdsdToolStripMenuItem.Click += new System.EventHandler(this.sdsdToolStripMenuItem_Click);
            // 
            // sdsToolStripMenuItem
            // 
            this.sdsToolStripMenuItem.Name = "sdsToolStripMenuItem";
            this.sdsToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.sdsToolStripMenuItem.Text = "Productos";
            this.sdsToolStripMenuItem.Click += new System.EventHandler(this.sdsToolStripMenuItem_Click);
            // 
            // sdsdToolStripMenuItem1
            // 
            this.sdsdToolStripMenuItem1.Name = "sdsdToolStripMenuItem1";
            this.sdsdToolStripMenuItem1.Size = new System.Drawing.Size(197, 34);
            this.sdsdToolStripMenuItem1.Text = "Mesas";
            this.sdsdToolStripMenuItem1.Click += new System.EventHandler(this.sdsdToolStripMenuItem1_Click);
            // 
            // sdsdToolStripMenuItem2
            // 
            this.sdsdToolStripMenuItem2.Name = "sdsdToolStripMenuItem2";
            this.sdsdToolStripMenuItem2.Size = new System.Drawing.Size(197, 34);
            this.sdsdToolStripMenuItem2.Text = "Provedores";
            this.sdsdToolStripMenuItem2.Click += new System.EventHandler(this.sdsdToolStripMenuItem2_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.recetasToolStripMenuItem.Text = "Recetas";
            this.recetasToolStripMenuItem.Click += new System.EventHandler(this.recetasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlUsuarios.Controls.Add(this.tabPageFinanzas);
            this.tabControlUsuarios.Controls.Add(this.tabPageBodega);
            this.tabControlUsuarios.Controls.Add(this.tabPageMantenimiento);
            this.tabControlUsuarios.Controls.Add(this.tabPageReportes);
            this.tabControlUsuarios.Controls.Add(this.tabPageUsuario);
            this.tabControlUsuarios.Controls.Add(this.tabPageProductos);
            this.tabControlUsuarios.Controls.Add(this.tabPageMesas);
            this.tabControlUsuarios.Controls.Add(this.tabPage4);
            this.tabControlUsuarios.Controls.Add(this.tabPageRecetas);
            this.tabControlUsuarios.Controls.Add(this.tabPageClientes);
            this.tabControlUsuarios.Controls.Add(this.tabPage1);
            this.tabControlUsuarios.Controls.Add(this.tabPage2);
            this.tabControlUsuarios.Location = new System.Drawing.Point(0, 121);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(1332, 528);
            this.tabControlUsuarios.TabIndex = 1;
            // 
            // tabPageFinanzas
            // 
            this.tabPageFinanzas.Controls.Add(this.label3);
            this.tabPageFinanzas.Location = new System.Drawing.Point(4, 22);
            this.tabPageFinanzas.Name = "tabPageFinanzas";
            this.tabPageFinanzas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinanzas.Size = new System.Drawing.Size(1324, 502);
            this.tabPageFinanzas.TabIndex = 0;
            this.tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1002, 214);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido a \r\nrestaurante siglo XXI ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPageBodega
            // 
            this.tabPageBodega.Controls.Add(this.label5);
            this.tabPageBodega.Location = new System.Drawing.Point(4, 22);
            this.tabPageBodega.Name = "tabPageBodega";
            this.tabPageBodega.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBodega.Size = new System.Drawing.Size(1324, 502);
            this.tabPageBodega.TabIndex = 1;
            this.tabPageBodega.Text = "tabPage2";
            this.tabPageBodega.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "f";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.label6);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(1324, 502);
            this.tabPageMantenimiento.TabIndex = 2;
            this.tabPageMantenimiento.Text = "tabPage1";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "b";
            // 
            // tabPageReportes
            // 
            this.tabPageReportes.Controls.Add(this.label2);
            this.tabPageReportes.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportes.Name = "tabPageReportes";
            this.tabPageReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportes.Size = new System.Drawing.Size(1324, 502);
            this.tabPageReportes.TabIndex = 3;
            this.tabPageReportes.Text = "tabPage2";
            this.tabPageReportes.UseVisualStyleBackColor = true;
            this.tabPageReportes.Click += new System.EventHandler(this.tabPageReportes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "r";
            // 
            // tabPageUsuario
            // 
            this.tabPageUsuario.Controls.Add(this.button2);
            this.tabPageUsuario.Controls.Add(this.dataGridView1);
            this.tabPageUsuario.Controls.Add(this.button1);
            this.tabPageUsuario.Controls.Add(this.label15);
            this.tabPageUsuario.Controls.Add(this.label14);
            this.tabPageUsuario.Controls.Add(this.label13);
            this.tabPageUsuario.Controls.Add(this.label7);
            this.tabPageUsuario.Controls.Add(this.comboBoxRoles);
            this.tabPageUsuario.Controls.Add(this.textBoxContrasena);
            this.tabPageUsuario.Controls.Add(this.textBoxEmail);
            this.tabPageUsuario.Controls.Add(this.textBoxNombreUsuario);
            this.tabPageUsuario.Controls.Add(this.label12);
            this.tabPageUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsuario.Name = "tabPageUsuario";
            this.tabPageUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsuario.Size = new System.Drawing.Size(1324, 502);
            this.tabPageUsuario.TabIndex = 4;
            this.tabPageUsuario.Text = "tabPage1";
            this.tabPageUsuario.UseVisualStyleBackColor = true;
            this.tabPageUsuario.Click += new System.EventHandler(this.tabPageUsuario_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1194, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Refrescar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.cONTRASENADataGridViewTextBoxColumn,
            this.Eliminar,
            this.ID_USUARIO});
            this.dataGridView1.DataSource = this.uSUARIOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(849, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 270);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // cONTRASENADataGridViewTextBoxColumn
            // 
            this.cONTRASENADataGridViewTextBoxColumn.DataPropertyName = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.HeaderText = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.Name = "cONTRASENADataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "ID_USUARIO";
            this.ID_USUARIO.HeaderText = "ID_USUARIO";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.Visible = false;
            // 
            // uSUARIOBindingSource1
            // 
            this.uSUARIOBindingSource1.DataMember = "USUARIO";
            this.uSUARIOBindingSource1.DataSource = this.usuarios;
            // 
            // usuarios
            // 
            this.usuarios.DataSetName = "usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 26);
            this.label15.TabIndex = 9;
            this.label15.Text = "Rol del usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 26);
            this.label14.TabIndex = 8;
            this.label14.Text = "Contraseña del usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 26);
            this.label13.TabIndex = 7;
            this.label13.Text = "Direccion de correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ingrese nombre de usuario";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.DataSource = this.rOLESBindingSource4;
            this.comboBoxRoles.DisplayMember = "NOMBREROL";
            this.comboBoxRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(15, 365);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(230, 37);
            this.comboBoxRoles.TabIndex = 5;
            this.comboBoxRoles.ValueMember = "ID_ROLES";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // rOLESBindingSource4
            // 
            this.rOLESBindingSource4.DataMember = "ROLES";
            this.rOLESBindingSource4.DataSource = this.roles;
            // 
            // roles
            // 
            this.roles.DataSetName = "roles";
            this.roles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.Location = new System.Drawing.Point(15, 255);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(289, 38);
            this.textBoxContrasena.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(348, 131);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(289, 38);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(15, 131);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(289, 38);
            this.textBoxNombreUsuario.TabIndex = 2;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 40);
            this.label12.TabIndex = 1;
            this.label12.Text = "Registro de usuarios";
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.label37);
            this.tabPageProductos.Controls.Add(this.label24);
            this.tabPageProductos.Controls.Add(this.button3);
            this.tabPageProductos.Controls.Add(this.dataGridView3);
            this.tabPageProductos.Controls.Add(this.label19);
            this.tabPageProductos.Controls.Add(this.comboBoxPro);
            this.tabPageProductos.Controls.Add(this.textBoxStock);
            this.tabPageProductos.Controls.Add(this.textBoxStockMinimo);
            this.tabPageProductos.Controls.Add(this.textBoxDescripcion);
            this.tabPageProductos.Controls.Add(this.textBoxPrecio);
            this.tabPageProductos.Controls.Add(this.textBoxNP);
            this.tabPageProductos.Controls.Add(this.label18);
            this.tabPageProductos.Controls.Add(this.label17);
            this.tabPageProductos.Controls.Add(this.label16);
            this.tabPageProductos.Controls.Add(this.label8);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(1324, 502);
            this.tabPageProductos.TabIndex = 5;
            this.tabPageProductos.Text = "tabPage2";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            this.tabPageProductos.Click += new System.EventHandler(this.tabPageProductos_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(316, 267);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(145, 26);
            this.label37.TabIndex = 14;
            this.label37.Text = "Stock mínimo";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(25, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(300, 39);
            this.label24.TabIndex = 12;
            this.label24.Text = "Agregar Productos";
            this.label24.Visible = false;
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(189, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar Producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(565, 92);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(736, 275);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick_1);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(316, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 26);
            this.label19.TabIndex = 9;
            this.label19.Text = "Proveedor";
            // 
            // comboBoxPro
            // 
            this.comboBoxPro.DataSource = this.pROVEEDORBindingSource;
            this.comboBoxPro.DisplayMember = "NOMBRE";
            this.comboBoxPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPro.FormattingEnabled = true;
            this.comboBoxPro.Location = new System.Drawing.Point(321, 107);
            this.comboBoxPro.Name = "comboBoxPro";
            this.comboBoxPro.Size = new System.Drawing.Size(210, 33);
            this.comboBoxPro.TabIndex = 8;
            this.comboBoxPro.ValueMember = "ID_PROVEEDOR";
            // 
            // pROVEEDORBindingSource
            // 
            this.pROVEEDORBindingSource.DataMember = "PROVEEDOR";
            this.pROVEEDORBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(321, 199);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(210, 32);
            this.textBoxStock.TabIndex = 7;
            this.textBoxStock.TextChanged += new System.EventHandler(this.textBoxStock_TextChanged);
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockMinimo.Location = new System.Drawing.Point(321, 296);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(210, 32);
            this.textBoxStockMinimo.TabIndex = 13;
            this.textBoxStockMinimo.TextChanged += new System.EventHandler(this.textBoxStockMinimo_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(32, 296);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(210, 32);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(32, 199);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(210, 32);
            this.textBoxPrecio.TabIndex = 5;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // textBoxNP
            // 
            this.textBoxNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNP.Location = new System.Drawing.Point(32, 108);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(210, 32);
            this.textBoxNP.TabIndex = 4;
            this.textBoxNP.TextChanged += new System.EventHandler(this.textBoxNP_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 26);
            this.label18.TabIndex = 3;
            this.label18.Text = "Precio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 26);
            this.label17.TabIndex = 2;
            this.label17.Text = "Descripcion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(316, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 26);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cantidad (stock)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del producto";
            // 
            // tabPageMesas
            // 
            this.tabPageMesas.Controls.Add(this.label38);
            this.tabPageMesas.Controls.Add(this.txtDesc);
            this.tabPageMesas.Controls.Add(this.button4);
            this.tabPageMesas.Controls.Add(this.dataGridView4);
            this.tabPageMesas.Controls.Add(this.label23);
            this.tabPageMesas.Controls.Add(this.label22);
            this.tabPageMesas.Controls.Add(this.label21);
            this.tabPageMesas.Controls.Add(this.label20);
            this.tabPageMesas.Controls.Add(this.txtCapacidad1);
            this.tabPageMesas.Controls.Add(this.txtCapacidad);
            this.tabPageMesas.Controls.Add(this.txtDescripcion);
            this.tabPageMesas.Controls.Add(this.txtEstado);
            this.tabPageMesas.Controls.Add(this.txtNumMesa);
            this.tabPageMesas.Controls.Add(this.label9);
            this.tabPageMesas.Location = new System.Drawing.Point(4, 22);
            this.tabPageMesas.Name = "tabPageMesas";
            this.tabPageMesas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMesas.Size = new System.Drawing.Size(1324, 502);
            this.tabPageMesas.TabIndex = 6;
            this.tabPageMesas.Text = "tabPage3";
            this.tabPageMesas.UseVisualStyleBackColor = true;
            this.tabPageMesas.Click += new System.EventHandler(this.tabPageMesas_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(328, 226);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(110, 24);
            this.label38.TabIndex = 11;
            this.label38.Text = "Descripcion";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(331, 253);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(238, 32);
            this.txtDesc.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(196, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MESA,
            this.cAPACIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.Borrar});
            this.dataGridView4.DataSource = this.mESABindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(785, 125);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(438, 257);
            this.dataGridView4.TabIndex = 8;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick_1);
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // mESABindingSource
            // 
            this.mESABindingSource.DataMember = "MESA";
            this.mESABindingSource.DataSource = this.mesas;
            // 
            // mesas
            // 
            this.mesas.DataSetName = "Mesas";
            this.mesas.EnforceConstraints = false;
            this.mesas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(25, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 24);
            this.label23.TabIndex = 7;
            this.label23.Text = "Estado";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(25, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(195, 24);
            this.label22.TabIndex = 6;
            this.label22.Text = "Cantidad de Personas";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(252, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(327, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 24);
            this.label20.TabIndex = 4;
            this.label20.Text = "Numero de Mesa";
            // 
            // txtCapacidad1
            // 
            this.txtCapacidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad1.Location = new System.Drawing.Point(29, 253);
            this.txtCapacidad1.Name = "txtCapacidad1";
            this.txtCapacidad1.Size = new System.Drawing.Size(191, 32);
            this.txtCapacidad1.TabIndex = 3;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidad.Location = new System.Drawing.Point(29, 253);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(152, 32);
            this.txtCapacidad.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(29, 253);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(152, 32);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(29, 152);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(262, 32);
            this.txtEstado.TabIndex = 2;
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMesa.Location = new System.Drawing.Point(331, 152);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(154, 32);
            this.txtNumMesa.TabIndex = 1;
            this.txtNumMesa.TextChanged += new System.EventHandler(this.txtIdMesa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agregar Mesas";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1324, 502);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "provedores";
            // 
            // tabPageRecetas
            // 
            this.tabPageRecetas.Controls.Add(this.label11);
            this.tabPageRecetas.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecetas.Name = "tabPageRecetas";
            this.tabPageRecetas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecetas.Size = new System.Drawing.Size(1324, 502);
            this.tabPageRecetas.TabIndex = 8;
            this.tabPageRecetas.Text = "tabPage1";
            this.tabPageRecetas.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "recetas";
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Controls.Add(this.dataGridView2);
            this.tabPageClientes.Controls.Add(this.label25);
            this.tabPageClientes.Controls.Add(this.button6);
            this.tabPageClientes.Controls.Add(this.button5);
            this.tabPageClientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientes.Size = new System.Drawing.Size(1324, 502);
            this.tabPageClientes.TabIndex = 9;
            this.tabPageClientes.Text = "tabPage1";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBRECLIDataGridViewTextBoxColumn,
            this.aPELLIDOCLIDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn1,
            this.tELEFONODataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cLIENTEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(827, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(440, 310);
            this.dataGridView2.TabIndex = 3;
            // 
            // nOMBRECLIDataGridViewTextBoxColumn
            // 
            this.nOMBRECLIDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn.HeaderText = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn.Name = "nOMBRECLIDataGridViewTextBoxColumn";
            // 
            // aPELLIDOCLIDataGridViewTextBoxColumn
            // 
            this.aPELLIDOCLIDataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn.HeaderText = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn.Name = "aPELLIDOCLIDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn1
            // 
            this.eMAILDataGridViewTextBoxColumn1.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn1.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn1.Name = "eMAILDataGridViewTextBoxColumn1";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cliente;
            // 
            // cliente
            // 
            this.cliente.DataSetName = "Cliente";
            this.cliente.EnforceConstraints = false;
            this.cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(18, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(334, 31);
            this.label25.TabIndex = 2;
            this.label25.Text = "Mantenimiento de Clientes";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 48);
            this.button6.TabIndex = 1;
            this.button6.Text = "Registro de Clientes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 48);
            this.button5.TabIndex = 0;
            this.button5.Text = "Modificar Clientes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.textBoxTC);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.textBoxEC);
            this.tabPage1.Controls.Add(this.textBoxAC);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.textBoxNC);
            this.tabPage1.Controls.Add(this.comboBoxCliente);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 502);
            this.tabPage1.TabIndex = 10;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(263, 377);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 35);
            this.button8.TabIndex = 14;
            this.button8.Text = "Volver";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(34, 91);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(133, 25);
            this.label32.TabIndex = 13;
            this.label32.Text = "Seleccione ID";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(25, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 35);
            this.button7.TabIndex = 12;
            this.button7.Text = "Modificar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTC.Location = new System.Drawing.Point(263, 316);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(180, 30);
            this.textBoxTC.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(258, 288);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 25);
            this.label31.TabIndex = 10;
            this.label31.Text = "Telefono";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(20, 288);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 25);
            this.label30.TabIndex = 9;
            this.label30.Text = "Email";
            // 
            // textBoxEC
            // 
            this.textBoxEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEC.Location = new System.Drawing.Point(25, 316);
            this.textBoxEC.Name = "textBoxEC";
            this.textBoxEC.Size = new System.Drawing.Size(192, 30);
            this.textBoxEC.TabIndex = 8;
            // 
            // textBoxAC
            // 
            this.textBoxAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAC.Location = new System.Drawing.Point(263, 233);
            this.textBoxAC.Name = "textBoxAC";
            this.textBoxAC.Size = new System.Drawing.Size(180, 30);
            this.textBoxAC.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(259, 198);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 24);
            this.label29.TabIndex = 6;
            this.label29.Text = "Apellido Cliente";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(21, 198);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 24);
            this.label28.TabIndex = 5;
            this.label28.Text = "Nombre Cliente";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // textBoxNC
            // 
            this.textBoxNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNC.Location = new System.Drawing.Point(24, 233);
            this.textBoxNC.Name = "textBoxNC";
            this.textBoxNC.Size = new System.Drawing.Size(193, 30);
            this.textBoxNC.TabIndex = 4;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DataSource = this.cLIENTEBindingSource;
            this.comboBoxCliente.DisplayMember = "ID_CLIENTE";
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(37, 124);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(264, 33);
            this.comboBoxCliente.TabIndex = 2;
            this.comboBoxCliente.ValueMember = "ID_CLIENTE";
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_3);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(30, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(271, 39);
            this.label26.TabIndex = 0;
            this.label26.Text = "Modificar Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.textBoxEC1);
            this.tabPage2.Controls.Add(this.textBoxTC1);
            this.tabPage2.Controls.Add(this.textBoxAC1);
            this.tabPage2.Controls.Add(this.textBoxNC1);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1324, 502);
            this.tabPage2.TabIndex = 11;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(280, 131);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(148, 25);
            this.label36.TabIndex = 11;
            this.label36.Text = "Apellido Cliente";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(19, 213);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 25);
            this.label35.TabIndex = 10;
            this.label35.Text = "Telefono";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(281, 213);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(60, 25);
            this.label34.TabIndex = 9;
            this.label34.Text = "Email";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(19, 131);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(147, 25);
            this.label33.TabIndex = 8;
            this.label33.Text = "Nombre Cliente";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(285, 316);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(174, 46);
            this.button10.TabIndex = 7;
            this.button10.Text = "Volver";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(24, 316);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 46);
            this.button9.TabIndex = 6;
            this.button9.Text = "Agregar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBoxEC1
            // 
            this.textBoxEC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEC1.Location = new System.Drawing.Point(285, 241);
            this.textBoxEC1.Name = "textBoxEC1";
            this.textBoxEC1.Size = new System.Drawing.Size(162, 30);
            this.textBoxEC1.TabIndex = 5;
            // 
            // textBoxTC1
            // 
            this.textBoxTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTC1.Location = new System.Drawing.Point(24, 241);
            this.textBoxTC1.Name = "textBoxTC1";
            this.textBoxTC1.Size = new System.Drawing.Size(174, 30);
            this.textBoxTC1.TabIndex = 4;
            // 
            // textBoxAC1
            // 
            this.textBoxAC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAC1.Location = new System.Drawing.Point(285, 167);
            this.textBoxAC1.Name = "textBoxAC1";
            this.textBoxAC1.Size = new System.Drawing.Size(162, 30);
            this.textBoxAC1.TabIndex = 3;
            this.textBoxAC1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxNC1
            // 
            this.textBoxNC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNC1.Location = new System.Drawing.Point(24, 167);
            this.textBoxNC1.Name = "textBoxNC1";
            this.textBoxNC1.Size = new System.Drawing.Size(174, 30);
            this.textBoxNC1.TabIndex = 2;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBRECLIDataGridViewTextBoxColumn2,
            this.aPELLIDOCLIDataGridViewTextBoxColumn2,
            this.eMAILDataGridViewTextBoxColumn3,
            this.tELEFONODataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.cLIENTEBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(773, 100);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(443, 262);
            this.dataGridView6.TabIndex = 1;
            // 
            // nOMBRECLIDataGridViewTextBoxColumn2
            // 
            this.nOMBRECLIDataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn2.HeaderText = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn2.Name = "nOMBRECLIDataGridViewTextBoxColumn2";
            // 
            // aPELLIDOCLIDataGridViewTextBoxColumn2
            // 
            this.aPELLIDOCLIDataGridViewTextBoxColumn2.DataPropertyName = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn2.HeaderText = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn2.Name = "aPELLIDOCLIDataGridViewTextBoxColumn2";
            // 
            // eMAILDataGridViewTextBoxColumn3
            // 
            this.eMAILDataGridViewTextBoxColumn3.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn3.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn3.Name = "eMAILDataGridViewTextBoxColumn3";
            // 
            // tELEFONODataGridViewTextBoxColumn2
            // 
            this.tELEFONODataGridViewTextBoxColumn2.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn2.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn2.Name = "tELEFONODataGridViewTextBoxColumn2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(17, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(307, 39);
            this.label27.TabIndex = 0;
            this.label27.Text = "Registro de Cliente";
            // 
            // productos
            // 
            this.productos.DataSetName = "Productos";
            this.productos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataSource = this.productos;
            this.productosBindingSource1.Position = 0;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.usuarios;
            // 
            // rOLESBindingSource2
            // 
            this.rOLESBindingSource2.DataMember = "ROLES";
            this.rOLESBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.joaa_arp_minimalist_restaurant_logo_ccd51406_7a12_46e2_ac0c_60e7b03b0c22;
            this.pictureBox1.Location = new System.Drawing.Point(28, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1169, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1214, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Joaquin Aravena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1217, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Administrador";
            // 
            // rOLESBindingSource
            // 
            this.rOLESBindingSource.DataMember = "ROLES";
            this.rOLESBindingSource.DataSource = this.dataSet1;
            // 
            // rOLESTableAdapter
            // 
            this.rOLESTableAdapter.ClearBeforeFill = true;
            // 
            // rOLESBindingSource1
            // 
            this.rOLESBindingSource1.DataMember = "ROLES";
            this.rOLESBindingSource1.DataSource = this.dataSet1;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // rOLESBindingSource3
            // 
            this.rOLESBindingSource3.DataMember = "ROLES";
            this.rOLESBindingSource3.DataSource = this.dataSet1;
            // 
            // rOLESTableAdapter2
            // 
            this.rOLESTableAdapter2.ClearBeforeFill = true;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = this.productos;
            this.productosBindingSource.Position = 0;
            // 
            // pROVEEDORTableAdapter
            // 
            this.pROVEEDORTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOTableAdapter
            // 
            this.pRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRODUCTOTableAdapter = this.pRODUCTOTableAdapter;
            this.tableAdapterManager.PROVEEDORTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.ProductosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROVEEDORTableAdapter1
            // 
            this.pROVEEDORTableAdapter1.ClearBeforeFill = true;
            // 
            // mESATableAdapter
            // 
            this.mESATableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE1,
            this.nOMBRECLIDataGridViewTextBoxColumn3,
            this.aPELLIDOCLIDataGridViewTextBoxColumn3,
            this.eMAILDataGridViewTextBoxColumn4,
            this.tELEFONODataGridViewTextBoxColumn3,
            this.BorrarCliente});
            this.dataGridView7.DataSource = this.cLIENTEBindingSource1;
            this.dataGridView7.Location = new System.Drawing.Point(657, 91);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(643, 353);
            this.dataGridView7.TabIndex = 15;
            this.dataGridView7.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellClick);
            // 
            // clientess
            // 
            this.clientess.DataSetName = "Clientess";
            this.clientess.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource1
            // 
            this.cLIENTEBindingSource1.DataMember = "CLIENTE";
            this.cLIENTEBindingSource1.DataSource = this.clientess;
            // 
            // cLIENTETableAdapter1
            // 
            this.cLIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // ID_CLIENTE1
            // 
            this.ID_CLIENTE1.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE1.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE1.Name = "ID_CLIENTE1";
            // 
            // nOMBRECLIDataGridViewTextBoxColumn3
            // 
            this.nOMBRECLIDataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn3.HeaderText = "NOMBRE_CLI";
            this.nOMBRECLIDataGridViewTextBoxColumn3.Name = "nOMBRECLIDataGridViewTextBoxColumn3";
            // 
            // aPELLIDOCLIDataGridViewTextBoxColumn3
            // 
            this.aPELLIDOCLIDataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn3.HeaderText = "APELLIDO_CLI";
            this.aPELLIDOCLIDataGridViewTextBoxColumn3.Name = "aPELLIDOCLIDataGridViewTextBoxColumn3";
            // 
            // eMAILDataGridViewTextBoxColumn4
            // 
            this.eMAILDataGridViewTextBoxColumn4.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn4.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn4.Name = "eMAILDataGridViewTextBoxColumn4";
            // 
            // tELEFONODataGridViewTextBoxColumn3
            // 
            this.tELEFONODataGridViewTextBoxColumn3.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn3.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn3.Name = "tELEFONODataGridViewTextBoxColumn3";
            // 
            // BorrarCliente
            // 
            this.BorrarCliente.HeaderText = "BorrarCliente";
            this.BorrarCliente.Name = "BorrarCliente";
            // 
            // ID_MESA
            // 
            this.ID_MESA.DataPropertyName = "ID_MESA";
            this.ID_MESA.HeaderText = "ID_MESA";
            this.ID_MESA.Name = "ID_MESA";
            // 
            // cAPACIDADDataGridViewTextBoxColumn
            // 
            this.cAPACIDADDataGridViewTextBoxColumn.DataPropertyName = "CAPACIDAD";
            this.cAPACIDADDataGridViewTextBoxColumn.HeaderText = "CAPACIDAD";
            this.cAPACIDADDataGridViewTextBoxColumn.Name = "cAPACIDADDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1339, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabPageFinanzas.ResumeLayout(false);
            this.tabPageBodega.ResumeLayout(false);
            this.tabPageBodega.PerformLayout();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabPageMantenimiento.PerformLayout();
            this.tabPageReportes.ResumeLayout(false);
            this.tabPageReportes.PerformLayout();
            this.tabPageUsuario.ResumeLayout(false);
            this.tabPageUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).EndInit();
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.tabPageMesas.ResumeLayout(false);
            this.tabPageMesas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPageRecetas.ResumeLayout(false);
            this.tabPageRecetas.PerformLayout();
            this.tabPageClientes.ResumeLayout(false);
            this.tabPageClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUCTOREFERENCEINVENTARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabPageFinanzas;
        private System.Windows.Forms.TabPage tabPageBodega;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.TabPage tabPageReportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageUsuario;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabPage tabPageMesas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageRecetas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.Label label12;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rOLESBindingSource;
        private DataSet1TableAdapters.ROLESTableAdapter rOLESTableAdapter;
        private System.Windows.Forms.BindingSource rOLESBindingSource2;
        private System.Windows.Forms.BindingSource rOLESBindingSource1;
        private DataSet1TableAdapters.ROLESTableAdapter rolesTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.BindingSource rOLESBindingSource3;
        private roles roles;
        private System.Windows.Forms.BindingSource rOLESBindingSource4;
        private rolesTableAdapters.ROLESTableAdapter rOLESTableAdapter2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private usuarios usuarios;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private usuariosTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxStockMinimo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxPro;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Productos productos;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource pROVEEDORBindingSource;
        private DataSet2TableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private ProductosTableAdapters.PRODUCTOTableAdapter pRODUCTOTableAdapter;
        private ProductosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource fKPRODUCTOREFERENCEINVENTARBindingSource;
        private ProductosTableAdapters.PROVEEDORTableAdapter pROVEEDORTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCapacidad1;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNumMesa;
        private Mesas mesas;
        private System.Windows.Forms.BindingSource mESABindingSource;
        private MesasTableAdapters.MESATableAdapter mESATableAdapter;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private Cliente cliente;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private ClienteTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxNC;
        private System.Windows.Forms.TextBox textBoxAC;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxEC;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECLIDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOCLIDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBoxEC1;
        private System.Windows.Forms.TextBox textBoxTC1;
        private System.Windows.Forms.TextBox textBoxAC1;
        private System.Windows.Forms.TextBox textBoxNC1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private Label label37;
        private TextBox txtDesc;
        private Label label38;
        private DataGridView dataGridView7;
        private Clientess clientess;
        private BindingSource cLIENTEBindingSource1;
        private ClientessTableAdapters.CLIENTETableAdapter cLIENTETableAdapter1;
        private DataGridViewTextBoxColumn ID_CLIENTE1;
        private DataGridViewTextBoxColumn nOMBRECLIDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn aPELLIDOCLIDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn BorrarCliente;
        private DataGridViewTextBoxColumn ID_MESA;
        private DataGridViewTextBoxColumn cAPACIDADDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Borrar;
    }
}