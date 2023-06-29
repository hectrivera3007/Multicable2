
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
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.pais_ZonaTextBox = new System.Windows.Forms.TextBox();
            this.personaContactoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.nuevoRegistro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proveedoresTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.num_TelefonoTextBox = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo_ProveedorLabel
            // 
            tipo_ProveedorLabel.AutoSize = true;
            tipo_ProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            tipo_ProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_ProveedorLabel.Location = new System.Drawing.Point(428, 265);
            tipo_ProveedorLabel.Name = "tipo_ProveedorLabel";
            tipo_ProveedorLabel.Size = new System.Drawing.Size(108, 16);
            tipo_ProveedorLabel.TabIndex = 88;
            tipo_ProveedorLabel.Text = "Tipo Proveedor:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.BackColor = System.Drawing.Color.Transparent;
            correoElectronicoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoElectronicoLabel.Location = new System.Drawing.Point(279, 311);
            correoElectronicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(132, 16);
            correoElectronicoLabel.TabIndex = 69;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(45, 214);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 72;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            nombreProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.Location = new System.Drawing.Point(45, 170);
            nombreProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(133, 16);
            nombreProveedorLabel.TabIndex = 76;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(46, 355);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 78;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(45, 311);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 79;
            num_TelefonoLabel.Text = "Número de Teléfono:";
            // 
            // pais_ZonaLabel
            // 
            pais_ZonaLabel.AutoSize = true;
            pais_ZonaLabel.BackColor = System.Drawing.Color.Transparent;
            pais_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pais_ZonaLabel.Location = new System.Drawing.Point(428, 214);
            pais_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pais_ZonaLabel.Name = "pais_ZonaLabel";
            pais_ZonaLabel.Size = new System.Drawing.Size(76, 16);
            pais_ZonaLabel.TabIndex = 80;
            pais_ZonaLabel.Text = "Pais/Zona:";
            // 
            // personaContactoLabel
            // 
            personaContactoLabel.AutoSize = true;
            personaContactoLabel.BackColor = System.Drawing.Color.Transparent;
            personaContactoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personaContactoLabel.Location = new System.Drawing.Point(428, 170);
            personaContactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personaContactoLabel.Name = "personaContactoLabel";
            personaContactoLabel.Size = new System.Drawing.Size(126, 16);
            personaContactoLabel.TabIndex = 81;
            personaContactoLabel.Text = "Persona Contacto:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.BackColor = System.Drawing.Color.Transparent;
            rTNLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rTNLabel.Location = new System.Drawing.Point(277, 170);
            rTNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(36, 16);
            rTNLabel.TabIndex = 82;
            rTNLabel.Text = "RTN:";
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            iDProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDProveedorLabel.Location = new System.Drawing.Point(46, 124);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(94, 16);
            iDProveedorLabel.TabIndex = 93;
            iDProveedorLabel.Text = "ID Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(237, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 32);
            this.label2.TabIndex = 92;
            this.label2.Text = "REGISTRAR PROVEEDOR";
            // 
            // tipo_ProveedorComboBox
            // 
            this.tipo_ProveedorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.tipo_ProveedorComboBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tipo_ProveedorComboBox.FormattingEnabled = true;
            this.tipo_ProveedorComboBox.Items.AddRange(new object[] {
            "Local",
            "Extranjero"});
            this.tipo_ProveedorComboBox.Location = new System.Drawing.Point(431, 283);
            this.tipo_ProveedorComboBox.Name = "tipo_ProveedorComboBox";
            this.tipo_ProveedorComboBox.Size = new System.Drawing.Size(191, 25);
            this.tipo_ProveedorComboBox.TabIndex = 6;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(280, 330);
            this.correoElectronicoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(342, 24);
            this.correoElectronicoTextBox.TabIndex = 8;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.direccionTextBox.Location = new System.Drawing.Point(48, 233);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(364, 75);
            this.direccionTextBox.TabIndex = 4;
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(48, 189);
            this.nombreProveedorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(213, 24);
            this.nombreProveedorTextBox.TabIndex = 1;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.notasTextBox.Location = new System.Drawing.Point(48, 374);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(574, 65);
            this.notasTextBox.TabIndex = 9;
            // 
            // pais_ZonaTextBox
            // 
            this.pais_ZonaTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.pais_ZonaTextBox.Location = new System.Drawing.Point(431, 233);
            this.pais_ZonaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pais_ZonaTextBox.Name = "pais_ZonaTextBox";
            this.pais_ZonaTextBox.Size = new System.Drawing.Size(191, 24);
            this.pais_ZonaTextBox.TabIndex = 5;
            // 
            // personaContactoTextBox
            // 
            this.personaContactoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.personaContactoTextBox.Location = new System.Drawing.Point(431, 189);
            this.personaContactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personaContactoTextBox.Name = "personaContactoTextBox";
            this.personaContactoTextBox.Size = new System.Drawing.Size(191, 24);
            this.personaContactoTextBox.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(633, 411);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 90;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // nuevoRegistro
            // 
            this.nuevoRegistro.BackColor = System.Drawing.Color.Transparent;
            this.nuevoRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nuevoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nuevoRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("nuevoRegistro.Image")));
            this.nuevoRegistro.Location = new System.Drawing.Point(650, 229);
            this.nuevoRegistro.Name = "nuevoRegistro";
            this.nuevoRegistro.Size = new System.Drawing.Size(105, 28);
            this.nuevoRegistro.TabIndex = 87;
            this.nuevoRegistro.Text = "&Nuevo";
            this.nuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevoRegistro.UseVisualStyleBackColor = false;
            this.nuevoRegistro.Click += new System.EventHandler(this.nuevoRegistro_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(650, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 28);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(650, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 28);
            this.btnGuardar.TabIndex = 83;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Image = ((System.Drawing.Image)(resources.GetObject("btnMod.Image")));
            this.btnMod.Location = new System.Drawing.Point(650, 297);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(105, 28);
            this.btnMod.TabIndex = 84;
            this.btnMod.Text = "&Modificar";
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTNTextBox.Location = new System.Drawing.Point(280, 189);
            this.rTNTextBox.MaxLength = 14;
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(131, 23);
            this.rTNTextBox.TabIndex = 2;
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(49, 143);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.ReadOnly = true;
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDProveedorTextBox.TabIndex = 0;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.proveedoresBindingSource, "Activo", true));
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(629, 188);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(71, 24);
            this.activoCheckBox.TabIndex = 95;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.proveedoresDataGridView.DataSource = this.proveedoresBindingSource;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(-14, 470);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.Size = new System.Drawing.Size(769, 220);
            this.proveedoresDataGridView.TabIndex = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Proveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn3.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PersonaContacto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Persona Contacto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pais_Zona";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pais / Zona";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 190;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tipo_Proveedor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo de Proveedor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 190;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Num_Telefono";
            this.dataGridViewTextBoxColumn8.HeaderText = "Número de Teléfono";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 190;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CorreoElectronico";
            this.dataGridViewTextBoxColumn9.HeaderText = "Correo Electrónico";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn10.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // num_TelefonoTextBox
            // 
            this.num_TelefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TelefonoTextBox.Location = new System.Drawing.Point(49, 330);
            this.num_TelefonoTextBox.Mask = "+000 0000-0000";
            this.num_TelefonoTextBox.Name = "num_TelefonoTextBox";
            this.num_TelefonoTextBox.Size = new System.Drawing.Size(212, 23);
            this.num_TelefonoTextBox.TabIndex = 96;
            // 
            // FrmRegistrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 734);
            this.Controls.Add(this.num_TelefonoTextBox);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(tipo_ProveedorLabel);
            this.Controls.Add(this.tipo_ProveedorComboBox);
            this.Controls.Add(this.nuevoRegistro);
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
            this.Controls.Add(pais_ZonaLabel);
            this.Controls.Add(this.pais_ZonaTextBox);
            this.Controls.Add(personaContactoLabel);
            this.Controls.Add(this.personaContactoTextBox);
            this.Controls.Add(rTNLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Proveedor";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.ComboBox tipo_ProveedorComboBox;
        private System.Windows.Forms.Button nuevoRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreProveedorTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox pais_ZonaTextBox;
        private System.Windows.Forms.TextBox personaContactoTextBox;
        
        private System.Windows.Forms.TextBox rTNTextBox;
        private System.Windows.Forms.TextBox iDProveedorTextBox;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private _CATELSA_MULTICABLETableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.MaskedTextBox num_TelefonoTextBox;
    }
}