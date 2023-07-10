
namespace MultiBodega_v1
{
    partial class ModificarUsuario
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label confirmarContrasenaLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label numTelefonoLabel;
            System.Windows.Forms.Label rolIDLabel;
            System.Windows.Forms.Label fechaActivacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rolIDComboBox = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.ckContraseña = new System.Windows.Forms.CheckBox();
            this.bodegaIDComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmarContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.ckConfirmarContra = new System.Windows.Forms.CheckBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.bodegaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.BodegaTableAdapter();
            this.rolTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RolTableAdapter();
            this.numTelefonoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fechaActivacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            confirmarContrasenaLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            numTelefonoLabel = new System.Windows.Forms.Label();
            rolIDLabel = new System.Windows.Forms.Label();
            fechaActivacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(22, 136);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 16);
            iDLabel.TabIndex = 131;
            iDLabel.Text = "ID:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.BackColor = System.Drawing.Color.Transparent;
            nombreLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(332, 293);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(131, 16);
            nombreLabel1.TabIndex = 128;
            nombreLabel1.Text = "Bodega Asignada:";
            // 
            // confirmarContrasenaLabel
            // 
            confirmarContrasenaLabel.AutoSize = true;
            confirmarContrasenaLabel.BackColor = System.Drawing.Color.Transparent;
            confirmarContrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confirmarContrasenaLabel.Location = new System.Drawing.Point(22, 291);
            confirmarContrasenaLabel.Name = "confirmarContrasenaLabel";
            confirmarContrasenaLabel.Size = new System.Drawing.Size(156, 16);
            confirmarContrasenaLabel.TabIndex = 122;
            confirmarContrasenaLabel.Text = "Confirmar Contraseña:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.BackColor = System.Drawing.Color.Transparent;
            contrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(22, 246);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(87, 16);
            contrasenaLabel.TabIndex = 123;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(100, 136);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 124;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.BackColor = System.Drawing.Color.Transparent;
            nombreUsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreUsuarioLabel.Location = new System.Drawing.Point(22, 201);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(116, 16);
            nombreUsuarioLabel.TabIndex = 125;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // numTelefonoLabel
            // 
            numTelefonoLabel.AutoSize = true;
            numTelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            numTelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numTelefonoLabel.Location = new System.Drawing.Point(332, 201);
            numTelefonoLabel.Name = "numTelefonoLabel";
            numTelefonoLabel.Size = new System.Drawing.Size(142, 16);
            numTelefonoLabel.TabIndex = 126;
            numTelefonoLabel.Text = "Número de Teléfono:";
            // 
            // rolIDLabel
            // 
            rolIDLabel.AutoSize = true;
            rolIDLabel.BackColor = System.Drawing.Color.Transparent;
            rolIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolIDLabel.Location = new System.Drawing.Point(332, 246);
            rolIDLabel.Name = "rolIDLabel";
            rolIDLabel.Size = new System.Drawing.Size(32, 16);
            rolIDLabel.TabIndex = 127;
            rolIDLabel.Text = "Rol:";
            // 
            // fechaActivacionLabel
            // 
            fechaActivacionLabel.AutoSize = true;
            fechaActivacionLabel.BackColor = System.Drawing.Color.Transparent;
            fechaActivacionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaActivacionLabel.Location = new System.Drawing.Point(332, 136);
            fechaActivacionLabel.Name = "fechaActivacionLabel";
            fechaActivacionLabel.Size = new System.Drawing.Size(125, 16);
            fechaActivacionLabel.TabIndex = 133;
            fechaActivacionLabel.Text = "Fecha Activacion:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(22, 156);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(64, 23);
            this.iDTextBox.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::MultiBodega_v1.Properties.Resources.eliminar1;
            this.btnEliminar.Location = new System.Drawing.Point(300, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rolIDComboBox
            // 
            this.rolIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolBindingSource, "RolName", true));
            this.rolIDComboBox.DataSource = this.rolBindingSource;
            this.rolIDComboBox.DisplayMember = "RolName";
            this.rolIDComboBox.FormattingEnabled = true;
            this.rolIDComboBox.Location = new System.Drawing.Point(332, 265);
            this.rolIDComboBox.Name = "rolIDComboBox";
            this.rolIDComboBox.Size = new System.Drawing.Size(189, 25);
            this.rolIDComboBox.TabIndex = 8;
            this.rolIDComboBox.ValueMember = "RolID";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ckContraseña
            // 
            this.ckContraseña.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckContraseña.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckContraseña.FlatAppearance.BorderSize = 0;
            this.ckContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckContraseña.Image = global::MultiBodega_v1.Properties.Resources.mostrar;
            this.ckContraseña.Location = new System.Drawing.Point(282, 265);
            this.ckContraseña.Name = "ckContraseña";
            this.ckContraseña.Size = new System.Drawing.Size(32, 23);
            this.ckContraseña.TabIndex = 5;
            this.ckContraseña.UseVisualStyleBackColor = true;
            this.ckContraseña.CheckedChanged += new System.EventHandler(this.ckContraseña_CheckedChanged);
            // 
            // bodegaIDComboBox
            // 
            this.bodegaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bodegaBindingSource, "Nombre", true));
            this.bodegaIDComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaIDComboBox.DisplayMember = "Nombre";
            this.bodegaIDComboBox.FormattingEnabled = true;
            this.bodegaIDComboBox.Location = new System.Drawing.Point(332, 312);
            this.bodegaIDComboBox.Name = "bodegaIDComboBox";
            this.bodegaIDComboBox.Size = new System.Drawing.Size(189, 25);
            this.bodegaIDComboBox.TabIndex = 9;
            this.bodegaIDComboBox.ValueMember = "BodegaID";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(530, 312);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(68, 24);
            this.activoCheckBox.TabIndex = 10;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // confirmarContrasenaTextBox
            // 
            this.confirmarContrasenaTextBox.Location = new System.Drawing.Point(22, 310);
            this.confirmarContrasenaTextBox.Name = "confirmarContrasenaTextBox";
            this.confirmarContrasenaTextBox.Size = new System.Drawing.Size(254, 23);
            this.confirmarContrasenaTextBox.TabIndex = 6;
            this.confirmarContrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(22, 265);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(254, 23);
            this.contrasenaTextBox.TabIndex = 4;
            this.contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(100, 156);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(211, 23);
            this.nombreTextBox.TabIndex = 1;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(22, 220);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(254, 23);
            this.nombreUsuarioTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(164, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 120;
            this.label1.Text = "MODIFICAR USUARIO";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::MultiBodega_v1.Properties.Resources.actualizar1;
            this.BtnModificar.Location = new System.Drawing.Point(242, 363);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(55, 45);
            this.BtnModificar.TabIndex = 13;
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnRegresar.Location = new System.Drawing.Point(472, 374);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 15;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // ckConfirmarContra
            // 
            this.ckConfirmarContra.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckConfirmarContra.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckConfirmarContra.FlatAppearance.BorderSize = 0;
            this.ckConfirmarContra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckConfirmarContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckConfirmarContra.Image = global::MultiBodega_v1.Properties.Resources.mostrar;
            this.ckConfirmarContra.Location = new System.Drawing.Point(282, 312);
            this.ckConfirmarContra.Name = "ckConfirmarContra";
            this.ckConfirmarContra.Size = new System.Drawing.Size(32, 23);
            this.ckConfirmarContra.TabIndex = 7;
            this.ckConfirmarContra.UseVisualStyleBackColor = true;
            this.ckConfirmarContra.CheckedChanged += new System.EventHandler(this.ckConfirmarContra_CheckedChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BajosMinimosTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = this.bodegaTableAdapter;
            this.tableAdapterManager.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager.DevolucionesTableAdapter = null;
            this.tableAdapterManager.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager.PermisosAdministradorTableAdapter = null;
            this.tableAdapterManager.PermisosComprasTableAdapter = null;
            this.tableAdapterManager.PermisosEncargadoBodegaTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = this.rolTableAdapter;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // numTelefonoTextBox
            // 
            this.numTelefonoTextBox.Location = new System.Drawing.Point(332, 220);
            this.numTelefonoTextBox.Mask = "0000-0000";
            this.numTelefonoTextBox.Name = "numTelefonoTextBox";
            this.numTelefonoTextBox.Size = new System.Drawing.Size(189, 23);
            this.numTelefonoTextBox.TabIndex = 3;
            // 
            // fechaActivacionDateTimePicker
            // 
            this.fechaActivacionDateTimePicker.CustomFormat = "26/6/2023";
            this.fechaActivacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActivacionDateTimePicker.Location = new System.Drawing.Point(332, 156);
            this.fechaActivacionDateTimePicker.Name = "fechaActivacionDateTimePicker";
            this.fechaActivacionDateTimePicker.Size = new System.Drawing.Size(189, 23);
            this.fechaActivacionDateTimePicker.TabIndex = 132;
            this.fechaActivacionDateTimePicker.Value = new System.DateTime(2023, 6, 26, 0, 0, 0, 0);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 425);
            this.ControlBox = false;
            this.Controls.Add(fechaActivacionLabel);
            this.Controls.Add(this.fechaActivacionDateTimePicker);
            this.Controls.Add(this.numTelefonoTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.rolIDComboBox);
            this.Controls.Add(this.ckContraseña);
            this.Controls.Add(this.bodegaIDComboBox);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(confirmarContrasenaLabel);
            this.Controls.Add(this.confirmarContrasenaTextBox);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextBox);
            this.Controls.Add(numTelefonoLabel);
            this.Controls.Add(rolIDLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.ckConfirmarContra);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Cambios a Registro de Usuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.ComboBox rolIDComboBox;
        private System.Windows.Forms.CheckBox ckContraseña;
        public System.Windows.Forms.ComboBox bodegaIDComboBox;
        public System.Windows.Forms.CheckBox activoCheckBox;
        public System.Windows.Forms.TextBox confirmarContrasenaTextBox;
        public System.Windows.Forms.TextBox contrasenaTextBox;
        public System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.CheckBox ckConfirmarContra;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private _CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private _CATELSA_MULTICABLETableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private _CATELSA_MULTICABLETableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        public System.Windows.Forms.MaskedTextBox numTelefonoTextBox;
        public System.Windows.Forms.DateTimePicker fechaActivacionDateTimePicker;
    }
}