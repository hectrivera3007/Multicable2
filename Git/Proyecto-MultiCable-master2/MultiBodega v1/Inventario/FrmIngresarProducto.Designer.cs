
namespace MultiBodega_v1
{
    partial class FrmIngresarProducto
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label lblStockMin;
            System.Windows.Forms.Label codigoProdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label bodegaIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCodigoGen = new System.Windows.Forms.TextBox();
            this.CmbNombreTipo = new System.Windows.Forms.ComboBox();
            this.tipoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.DtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.bodegaIDComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.tipoMaterialTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TipoMaterialTableAdapter();
            this.bodegaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.BodegaTableAdapter();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label3 = new System.Windows.Forms.Label();
            lblStockMin = new System.Windows.Forms.Label();
            codigoProdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            bodegaIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(1000, 237);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 16);
            label3.TabIndex = 60;
            label3.Text = "Stock Máximo:";
            // 
            // lblStockMin
            // 
            lblStockMin.AutoSize = true;
            lblStockMin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStockMin.Location = new System.Drawing.Point(1005, 184);
            lblStockMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStockMin.Name = "lblStockMin";
            lblStockMin.Size = new System.Drawing.Size(98, 16);
            lblStockMin.TabIndex = 59;
            lblStockMin.Text = "Stock Mínimo:";
            // 
            // codigoProdLabel
            // 
            codigoProdLabel.AutoSize = true;
            codigoProdLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoProdLabel.Location = new System.Drawing.Point(19, 125);
            codigoProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoProdLabel.Name = "codigoProdLabel";
            codigoProdLabel.Size = new System.Drawing.Size(121, 16);
            codigoProdLabel.TabIndex = 52;
            codigoProdLabel.Text = "Código Producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(19, 217);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(89, 16);
            descripcionLabel.TabIndex = 53;
            descripcionLabel.Text = "Descripción:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaIngresoLabel.Location = new System.Drawing.Point(19, 172);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(103, 16);
            fechaIngresoLabel.TabIndex = 63;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDProductoLabel.Location = new System.Drawing.Point(19, 80);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(25, 16);
            iDProductoLabel.TabIndex = 67;
            iDProductoLabel.Text = "ID:";
            // 
            // bodegaIDLabel
            // 
            bodegaIDLabel.AutoSize = true;
            bodegaIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodegaIDLabel.Location = new System.Drawing.Point(19, 263);
            bodegaIDLabel.Name = "bodegaIDLabel";
            bodegaIDLabel.Size = new System.Drawing.Size(63, 16);
            bodegaIDLabel.TabIndex = 68;
            bodegaIDLabel.Text = "Bodega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(479, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = " PRODUCTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(1007, 257);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(95, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "1000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(1007, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "500";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCodigoGen
            // 
            this.TxtCodigoGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoGen.Location = new System.Drawing.Point(115, 145);
            this.TxtCodigoGen.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoGen.Name = "TxtCodigoGen";
            this.TxtCodigoGen.Size = new System.Drawing.Size(103, 23);
            this.TxtCodigoGen.TabIndex = 1;
            // 
            // CmbNombreTipo
            // 
            this.CmbNombreTipo.DataSource = this.tipoMaterialBindingSource;
            this.CmbNombreTipo.DisplayMember = "TipoMaterial";
            this.CmbNombreTipo.FormattingEnabled = true;
            this.CmbNombreTipo.Location = new System.Drawing.Point(19, 145);
            this.CmbNombreTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNombreTipo.Name = "CmbNombreTipo";
            this.CmbNombreTipo.Size = new System.Drawing.Size(76, 25);
            this.CmbNombreTipo.TabIndex = 0;
            this.CmbNombreTipo.ValueMember = "IDTipo";
            // 
            // tipoMaterialBindingSource
            // 
            this.tipoMaterialBindingSource.DataMember = "TipoMaterial";
            this.tipoMaterialBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(19, 237);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(194, 23);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // DtFechaIngreso
            // 
            this.DtFechaIngreso.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaIngreso.CustomFormat = "";
            this.DtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFechaIngreso.Location = new System.Drawing.Point(19, 192);
            this.DtFechaIngreso.Name = "DtFechaIngreso";
            this.DtFechaIngreso.Size = new System.Drawing.Size(199, 23);
            this.DtFechaIngreso.TabIndex = 2;
            this.DtFechaIngreso.Value = new System.DateTime(2023, 6, 22, 15, 15, 58, 0);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(19, 368);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(95, 26);
            this.BtnNuevo.TabIndex = 6;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(19, 436);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(95, 26);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(115, 402);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(95, 26);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(115, 368);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(95, 26);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(19, 402);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(95, 26);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(972, 481);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 11;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnQuitar.BackgroundImage")));
            this.BtnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnQuitar.Location = new System.Drawing.Point(1062, 288);
            this.BtnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(36, 28);
            this.BtnQuitar.TabIndex = 13;
            this.BtnQuitar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(1018, 288);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(36, 28);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(19, 308);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(68, 24);
            this.activoCheckBox.TabIndex = 5;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.Location = new System.Drawing.Point(19, 100);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.ReadOnly = true;
            this.iDProductoTextBox.Size = new System.Drawing.Size(76, 23);
            this.iDProductoTextBox.TabIndex = 68;
            // 
            // bodegaIDComboBox
            // 
            this.bodegaIDComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaIDComboBox.DisplayMember = "Nombre";
            this.bodegaIDComboBox.FormattingEnabled = true;
            this.bodegaIDComboBox.Location = new System.Drawing.Point(19, 283);
            this.bodegaIDComboBox.Name = "bodegaIDComboBox";
            this.bodegaIDComboBox.Size = new System.Drawing.Size(191, 25);
            this.bodegaIDComboBox.TabIndex = 4;
            this.bodegaIDComboBox.ValueMember = "BodegaID";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.iDProductoDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.TipoMaterial,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.bodegaIDDataGridViewTextBoxColumn,
            this.IDTipo,
            this.activoDataGridViewCheckBoxColumn});
            this.productoDataGridView.DataSource = this.productosBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(236, 125);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.Size = new System.Drawing.Size(749, 337);
            this.productoDataGridView.TabIndex = 69;
            this.productoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellContentClick);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajosMinimosTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager.PermisosAdministradorTableAdapter = null;
            this.tableAdapterManager.PermisosComprasTableAdapter = null;
            this.tableAdapterManager.PermisosEncargadoBodegaTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = this.tipoMaterialTableAdapter;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // tipoMaterialTableAdapter
            // 
            this.tipoMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 35;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Width = 40;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha de Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 150;
            // 
            // TipoMaterial
            // 
            this.TipoMaterial.DataPropertyName = "TipoMaterial";
            this.TipoMaterial.HeaderText = "Tipo de Material";
            this.TipoMaterial.Name = "TipoMaterial";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // bodegaIDDataGridViewTextBoxColumn
            // 
            this.bodegaIDDataGridViewTextBoxColumn.DataPropertyName = "BodegaID";
            this.bodegaIDDataGridViewTextBoxColumn.HeaderText = "Bodega Asignada";
            this.bodegaIDDataGridViewTextBoxColumn.Name = "bodegaIDDataGridViewTextBoxColumn";
            this.bodegaIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // IDTipo
            // 
            this.IDTipo.DataPropertyName = "IDTipo";
            this.IDTipo.HeaderText = "IDTipo";
            this.IDTipo.Name = "IDTipo";
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // FrmIngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1145, 540);
            this.Controls.Add(this.DtFechaIngreso);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(bodegaIDLabel);
            this.Controls.Add(this.bodegaIDComboBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label3);
            this.Controls.Add(lblStockMin);
            this.Controls.Add(this.TxtCodigoGen);
            this.Controls.Add(this.CmbNombreTipo);
            this.Controls.Add(codigoProdLabel);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(descripcionLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIngresarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nuevo Producto";
            this.Load += new System.EventHandler(this.FrmIngresarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtCodigoGen;
        private System.Windows.Forms.ComboBox CmbNombreTipo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.DateTimePicker DtFechaIngreso;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.ComboBox bodegaIDComboBox;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private _CATELSA_MULTICABLETableAdapters.ProductosTableAdapter productosTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private _CATELSA_MULTICABLETableAdapters.TipoMaterialTableAdapter tipoMaterialTableAdapter;
        private System.Windows.Forms.BindingSource tipoMaterialBindingSource;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private _CATELSA_MULTICABLETableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}