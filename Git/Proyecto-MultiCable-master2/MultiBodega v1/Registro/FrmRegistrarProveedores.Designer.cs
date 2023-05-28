
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmRegistrarProveedores
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
            System.Windows.Forms.Label tipo_ProveedorLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label num_TelefonoLabel;
            System.Windows.Forms.Label pais_ZonaLabel;
            System.Windows.Forms.Label personaContactoLabel;
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label iDProveedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.num_TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.pais_ZonaTextBox = new System.Windows.Forms.TextBox();
            this.personaContactoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.nuevoTextBox = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.proveedores1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLEDataSet = new MultiBodega_v1._CATELSA_MULTICABLEDataSet();
            this.rTNTextBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLEDataSetTableAdapters.TableAdapterManager();
            this.proveedores1TableAdapter = new MultiBodega_v1._CATELSA_MULTICABLEDataSetTableAdapters.Proveedores1TableAdapter();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisZonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tipo_ProveedorLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            pais_ZonaLabel = new System.Windows.Forms.Label();
            personaContactoLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            iDProveedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo_ProveedorLabel
            // 
            tipo_ProveedorLabel.AutoSize = true;
            tipo_ProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_ProveedorLabel.Location = new System.Drawing.Point(428, 219);
            tipo_ProveedorLabel.Name = "tipo_ProveedorLabel";
            tipo_ProveedorLabel.Size = new System.Drawing.Size(108, 16);
            tipo_ProveedorLabel.TabIndex = 88;
            tipo_ProveedorLabel.Text = "Tipo Proveedor:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoElectronicoLabel.Location = new System.Drawing.Point(279, 265);
            correoElectronicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(132, 16);
            correoElectronicoLabel.TabIndex = 69;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(45, 168);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 72;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.Location = new System.Drawing.Point(45, 124);
            nombreProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(133, 16);
            nombreProveedorLabel.TabIndex = 76;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(46, 309);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 78;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(45, 265);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 79;
            num_TelefonoLabel.Text = "Número de Telefono:";
            // 
            // pais_ZonaLabel
            // 
            pais_ZonaLabel.AutoSize = true;
            pais_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pais_ZonaLabel.Location = new System.Drawing.Point(428, 168);
            pais_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pais_ZonaLabel.Name = "pais_ZonaLabel";
            pais_ZonaLabel.Size = new System.Drawing.Size(76, 16);
            pais_ZonaLabel.TabIndex = 80;
            pais_ZonaLabel.Text = "Pais/Zona:";
            // 
            // personaContactoLabel
            // 
            personaContactoLabel.AutoSize = true;
            personaContactoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personaContactoLabel.Location = new System.Drawing.Point(428, 124);
            personaContactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personaContactoLabel.Name = "personaContactoLabel";
            personaContactoLabel.Size = new System.Drawing.Size(126, 16);
            personaContactoLabel.TabIndex = 81;
            personaContactoLabel.Text = "Persona Contacto:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rTNLabel.Location = new System.Drawing.Point(277, 124);
            rTNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(36, 16);
            rTNLabel.TabIndex = 82;
            rTNLabel.Text = "RTN:";
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDProveedorLabel.Location = new System.Drawing.Point(46, 78);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(94, 16);
            iDProveedorLabel.TabIndex = 93;
            iDProveedorLabel.Text = "ID Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(234, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 32);
            this.label2.TabIndex = 92;
            this.label2.Text = "REGISTRAR PROVEEDOR";
            // 
            // tipo_ProveedorComboBox
            // 
            this.tipo_ProveedorComboBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tipo_ProveedorComboBox.FormattingEnabled = true;
            this.tipo_ProveedorComboBox.Items.AddRange(new object[] {
            "Local",
            "Extranjero"});
            this.tipo_ProveedorComboBox.Location = new System.Drawing.Point(431, 237);
            this.tipo_ProveedorComboBox.Name = "tipo_ProveedorComboBox";
            this.tipo_ProveedorComboBox.Size = new System.Drawing.Size(191, 25);
            this.tipo_ProveedorComboBox.TabIndex = 6;
            this.tipo_ProveedorComboBox.Text = "Seleccione un tipo de proveedor";
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(280, 284);
            this.correoElectronicoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(342, 24);
            this.correoElectronicoTextBox.TabIndex = 8;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.direccionTextBox.Location = new System.Drawing.Point(48, 187);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(364, 75);
            this.direccionTextBox.TabIndex = 4;
            this.direccionTextBox.Text = "San Pedro Sula (SPS), 2552-2870,  9442-5546\r\nAve. Circunvalación.";
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(48, 143);
            this.nombreProveedorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(213, 24);
            this.nombreProveedorTextBox.TabIndex = 1;
            this.nombreProveedorTextBox.Text = "TecnoComp";
            // 
            // notasTextBox
            // 
            this.notasTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.notasTextBox.Location = new System.Drawing.Point(48, 328);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(574, 65);
            this.notasTextBox.TabIndex = 9;
            // 
            // num_TelefonoTextBox
            // 
            this.num_TelefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.num_TelefonoTextBox.Location = new System.Drawing.Point(49, 284);
            this.num_TelefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_TelefonoTextBox.Name = "num_TelefonoTextBox";
            this.num_TelefonoTextBox.Size = new System.Drawing.Size(212, 24);
            this.num_TelefonoTextBox.TabIndex = 7;
            // 
            // pais_ZonaTextBox
            // 
            this.pais_ZonaTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.pais_ZonaTextBox.Location = new System.Drawing.Point(431, 187);
            this.pais_ZonaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pais_ZonaTextBox.Name = "pais_ZonaTextBox";
            this.pais_ZonaTextBox.Size = new System.Drawing.Size(191, 24);
            this.pais_ZonaTextBox.TabIndex = 5;
            // 
            // personaContactoTextBox
            // 
            this.personaContactoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.personaContactoTextBox.Location = new System.Drawing.Point(431, 143);
            this.personaContactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personaContactoTextBox.Name = "personaContactoTextBox";
            this.personaContactoTextBox.Size = new System.Drawing.Size(191, 24);
            this.personaContactoTextBox.TabIndex = 3;
            this.personaContactoTextBox.Text = "Héctor Iván Rivera";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(633, 430);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 90;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // nuevoTextBox
            // 
            this.nuevoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoTextBox.Image = ((System.Drawing.Image)(resources.GetObject("nuevoTextBox.Image")));
            this.nuevoTextBox.Location = new System.Drawing.Point(650, 229);
            this.nuevoTextBox.Name = "nuevoTextBox";
            this.nuevoTextBox.Size = new System.Drawing.Size(105, 28);
            this.nuevoTextBox.TabIndex = 87;
            this.nuevoTextBox.Text = "&Nuevo";
            this.nuevoTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoTextBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevoTextBox.UseVisualStyleBackColor = true;
            this.nuevoTextBox.Click += new System.EventHandler(this.nuevoTextBox_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(650, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 28);
            this.btnSalir.TabIndex = 86;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(650, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(650, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 28);
            this.btnGuardar.TabIndex = 83;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Image = ((System.Drawing.Image)(resources.GetObject("btnMod.Image")));
            this.btnMod.Location = new System.Drawing.Point(650, 297);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(105, 28);
            this.btnMod.TabIndex = 84;
            this.btnMod.Text = "&Modificar";
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proveedoresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.rTNDataGridViewTextBoxColumn,
            this.personaContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.paisZonaDataGridViewTextBoxColumn,
            this.tipoProveedorDataGridViewTextBoxColumn,
            this.numTelefonoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.proveedoresDataGridView.DataSource = this.proveedores1BindingSource;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(48, 408);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.Size = new System.Drawing.Size(573, 80);
            this.proveedoresDataGridView.TabIndex = 93;
            // 
            // proveedores1BindingSource
            // 
            this.proveedores1BindingSource.DataMember = "Proveedores1";
            this.proveedores1BindingSource.DataSource = this._CATELSA_MULTICABLEDataSet;
            // 
            // _CATELSA_MULTICABLEDataSet
            // 
            this._CATELSA_MULTICABLEDataSet.DataSetName = "_CATELSA_MULTICABLEDataSet";
            this._CATELSA_MULTICABLEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rTNTextBox1
            // 
            this.rTNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedores1BindingSource, "RTN", true));
            this.rTNTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTNTextBox1.Location = new System.Drawing.Point(280, 143);
            this.rTNTextBox1.MaxLength = 14;
            this.rTNTextBox1.Name = "rTNTextBox1";
            this.rTNTextBox1.Size = new System.Drawing.Size(131, 23);
            this.rTNTextBox1.TabIndex = 2;
            this.rTNTextBox1.Text = "18041989034351";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajosMinimosTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager.PermisosTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Proveedores1TableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.Rol_PermisosTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Usuario_PermisosTableAdapter = null;
            this.tableAdapterManager.Usuario1TableAdapter = null;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // proveedores1TableAdapter
            // 
            this.proveedores1TableAdapter.ClearBeforeFill = true;
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedores1BindingSource, "IDProveedor", true));
            this.iDProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(49, 97);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDProveedorTextBox.TabIndex = 94;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProveedorDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            this.rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            this.rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNDataGridViewTextBoxColumn.MinimumWidth = 14;
            this.rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            // 
            // personaContactoDataGridViewTextBoxColumn
            // 
            this.personaContactoDataGridViewTextBoxColumn.DataPropertyName = "PersonaContacto";
            this.personaContactoDataGridViewTextBoxColumn.HeaderText = "Persona Contacto";
            this.personaContactoDataGridViewTextBoxColumn.Name = "personaContactoDataGridViewTextBoxColumn";
            this.personaContactoDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // paisZonaDataGridViewTextBoxColumn
            // 
            this.paisZonaDataGridViewTextBoxColumn.DataPropertyName = "Pais_Zona";
            this.paisZonaDataGridViewTextBoxColumn.HeaderText = "País/Zona";
            this.paisZonaDataGridViewTextBoxColumn.Name = "paisZonaDataGridViewTextBoxColumn";
            // 
            // tipoProveedorDataGridViewTextBoxColumn
            // 
            this.tipoProveedorDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Proveedor";
            this.tipoProveedorDataGridViewTextBoxColumn.HeaderText = "Tipo de Proveedor";
            this.tipoProveedorDataGridViewTextBoxColumn.Name = "tipoProveedorDataGridViewTextBoxColumn";
            // 
            // numTelefonoDataGridViewTextBoxColumn
            // 
            this.numTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn.Name = "numTelefonoDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            // 
            // FrmRegistrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(794, 500);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.rTNTextBox1);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(tipo_ProveedorLabel);
            this.Controls.Add(this.tipo_ProveedorComboBox);
            this.Controls.Add(this.nuevoTextBox);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombreProveedorLabel);
            this.Controls.Add(this.nombreProveedorTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(num_TelefonoLabel);
            this.Controls.Add(this.num_TelefonoTextBox);
            this.Controls.Add(pais_ZonaLabel);
            this.Controls.Add(this.pais_ZonaTextBox);
            this.Controls.Add(personaContactoLabel);
            this.Controls.Add(this.personaContactoTextBox);
            this.Controls.Add(rTNLabel);
            this.Name = "FrmRegistrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Proveedor";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.ComboBox tipo_ProveedorComboBox;
        private System.Windows.Forms.Button nuevoTextBox;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreProveedorTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox num_TelefonoTextBox;
        private System.Windows.Forms.TextBox pais_ZonaTextBox;
        private System.Windows.Forms.TextBox personaContactoTextBox;
        private _CATELSA_MULTICABLEDataSet _CATELSA_MULTICABLEDataSet;
        private _CATELSA_MULTICABLEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
        private System.Windows.Forms.BindingSource proveedores1BindingSource;
        private _CATELSA_MULTICABLEDataSetTableAdapters.Proveedores1TableAdapter proveedores1TableAdapter;
        private System.Windows.Forms.TextBox rTNTextBox1;
        private System.Windows.Forms.TextBox iDProveedorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisZonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
    }
}