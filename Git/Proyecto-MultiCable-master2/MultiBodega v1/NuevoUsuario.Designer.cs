
namespace MultiBodega_v1
{
    partial class NuevoUsuario
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
            System.Windows.Forms.Label confirmarContrasenaLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label numTelefonoLabel;
            System.Windows.Forms.Label rolIDLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.ckConfirmarContra = new System.Windows.Forms.CheckBox();
            this.ckContraseña = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmarContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.numTelefonoTextBox = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.bodegaIDComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_CATELSA_MULTICABLE = new MultiBodega_v1.BD_CATELSA_MULTICABLE();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolNameComboBox = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.rolTableAdapter = new MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters.RolTableAdapter();
            this.bodegaTableAdapter = new MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters.BodegaTableAdapter();
            confirmarContrasenaLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            numTelefonoLabel = new System.Windows.Forms.Label();
            rolIDLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmarContrasenaLabel
            // 
            confirmarContrasenaLabel.AutoSize = true;
            confirmarContrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confirmarContrasenaLabel.Location = new System.Drawing.Point(342, 168);
            confirmarContrasenaLabel.Name = "confirmarContrasenaLabel";
            confirmarContrasenaLabel.Size = new System.Drawing.Size(156, 16);
            confirmarContrasenaLabel.TabIndex = 88;
            confirmarContrasenaLabel.Text = "Confirmar Contraseña:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(41, 168);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(87, 16);
            contrasenaLabel.TabIndex = 90;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(41, 121);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 94;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreUsuarioLabel.Location = new System.Drawing.Point(342, 121);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(116, 16);
            nombreUsuarioLabel.TabIndex = 96;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // numTelefonoLabel
            // 
            numTelefonoLabel.AutoSize = true;
            numTelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numTelefonoLabel.Location = new System.Drawing.Point(641, 121);
            numTelefonoLabel.Name = "numTelefonoLabel";
            numTelefonoLabel.Size = new System.Drawing.Size(142, 16);
            numTelefonoLabel.TabIndex = 98;
            numTelefonoLabel.Text = "Número de Teléfono:";
            // 
            // rolIDLabel
            // 
            rolIDLabel.AutoSize = true;
            rolIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolIDLabel.Location = new System.Drawing.Point(41, 215);
            rolIDLabel.Name = "rolIDLabel";
            rolIDLabel.Size = new System.Drawing.Size(32, 16);
            rolIDLabel.TabIndex = 100;
            rolIDLabel.Text = "Rol:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(342, 215);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(131, 16);
            nombreLabel1.TabIndex = 103;
            nombreLabel1.Text = "Bodega Asignada:";
            // 
            // ckConfirmarContra
            // 
            this.ckConfirmarContra.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckConfirmarContra.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckConfirmarContra.FlatAppearance.BorderSize = 0;
            this.ckConfirmarContra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckConfirmarContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckConfirmarContra.Image = global::MultiBodega_v1.Properties.Resources.mostrar;
            this.ckConfirmarContra.Location = new System.Drawing.Point(569, 189);
            this.ckConfirmarContra.Name = "ckConfirmarContra";
            this.ckConfirmarContra.Size = new System.Drawing.Size(32, 23);
            this.ckConfirmarContra.TabIndex = 28;
            this.ckConfirmarContra.UseVisualStyleBackColor = true;
            this.ckConfirmarContra.CheckedChanged += new System.EventHandler(this.ckConfirmarContra_CheckedChanged);
            // 
            // ckContraseña
            // 
            this.ckContraseña.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckContraseña.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckContraseña.FlatAppearance.BorderSize = 0;
            this.ckContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckContraseña.Image = global::MultiBodega_v1.Properties.Resources.mostrar;
            this.ckContraseña.Location = new System.Drawing.Point(289, 187);
            this.ckContraseña.Name = "ckContraseña";
            this.ckContraseña.Size = new System.Drawing.Size(32, 23);
            this.ckContraseña.TabIndex = 29;
            this.ckContraseña.UseVisualStyleBackColor = true;
            this.ckContraseña.CheckedChanged += new System.EventHandler(this.ckContraseña_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(387, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "NUEVO USUARIO";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(569, 234);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(77, 24);
            this.activoCheckBox.TabIndex = 8;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // confirmarContrasenaTextBox
            // 
            this.confirmarContrasenaTextBox.Location = new System.Drawing.Point(342, 187);
            this.confirmarContrasenaTextBox.Name = "confirmarContrasenaTextBox";
            this.confirmarContrasenaTextBox.Size = new System.Drawing.Size(222, 23);
            this.confirmarContrasenaTextBox.TabIndex = 5;
            this.confirmarContrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(41, 187);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(242, 23);
            this.contrasenaTextBox.TabIndex = 4;
            this.contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(41, 140);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(242, 23);
            this.nombreTextBox.TabIndex = 1;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(342, 140);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(222, 23);
            this.nombreUsuarioTextBox.TabIndex = 2;
            // 
            // numTelefonoTextBox
            // 
            this.numTelefonoTextBox.Location = new System.Drawing.Point(641, 140);
            this.numTelefonoTextBox.MaxLength = 8;
            this.numTelefonoTextBox.Name = "numTelefonoTextBox";
            this.numTelefonoTextBox.Size = new System.Drawing.Size(235, 23);
            this.numTelefonoTextBox.TabIndex = 3;
            // 
            // BtnModificar
            // 
            this.BtnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.Location = new System.Drawing.Point(658, 231);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(105, 28);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(831, 526);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 66;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(771, 231);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 28);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // bodegaIDComboBox
            // 
            this.bodegaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bodegaBindingSource, "Nombre", true));
            this.bodegaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bodegaBindingSource, "Nombre", true));
            this.bodegaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bodegaBindingSource, "Nombre", true));
            this.bodegaIDComboBox.FormattingEnabled = true;
            this.bodegaIDComboBox.Location = new System.Drawing.Point(342, 234);
            this.bodegaIDComboBox.Name = "bodegaIDComboBox";
            this.bodegaIDComboBox.Size = new System.Drawing.Size(222, 25);
            this.bodegaIDComboBox.TabIndex = 7;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.bD_CATELSA_MULTICABLE;
            // 
            // bD_CATELSA_MULTICABLE
            // 
            this.bD_CATELSA_MULTICABLE.DataSetName = "BD_CATELSA_MULTICABLE";
            this.bD_CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.rolIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(-5, 295);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.Size = new System.Drawing.Size(1059, 220);
            this.usuarioDataGridView.TabIndex = 104;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre de Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumTelefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Número de Teléfono";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contrasena";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ConfirmarContrasena";
            this.dataGridViewTextBoxColumn6.HeaderText = "Confirmar Contraseña";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // rolIDDataGridViewTextBoxColumn
            // 
            this.rolIDDataGridViewTextBoxColumn.DataPropertyName = "RolID";
            this.rolIDDataGridViewTextBoxColumn.HeaderText = "RolID";
            this.rolIDDataGridViewTextBoxColumn.Name = "rolIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BodegaID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bodega";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bD_CATELSA_MULTICABLE;
            // 
            // rolNameComboBox
            // 
            this.rolNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rolNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.rolBindingSource, "RolName", true));
            this.rolNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolBindingSource, "RolName", true));
            this.rolNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolBindingSource, "RolID", true));
            this.rolNameComboBox.FormattingEnabled = true;
            this.rolNameComboBox.Location = new System.Drawing.Point(41, 234);
            this.rolNameComboBox.Name = "rolNameComboBox";
            this.rolNameComboBox.Size = new System.Drawing.Size(242, 25);
            this.rolNameComboBox.TabIndex = 105;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.bD_CATELSA_MULTICABLE;
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
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.BtnModificar;
            this.ClientSize = new System.Drawing.Size(1051, 606);
            this.Controls.Add(this.rolNameComboBox);
            this.Controls.Add(this.usuarioDataGridView);
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
            this.Controls.Add(this.numTelefonoTextBox);
            this.Controls.Add(rolIDLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.ckConfirmarContra);
            this.Controls.Add(this.BtnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nuevo Usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.CheckBox ckConfirmarContra;
        private System.Windows.Forms.CheckBox ckContraseña;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox confirmarContrasenaTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox numTelefonoTextBox;
        private System.Windows.Forms.ComboBox bodegaIDComboBox;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmarContrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaIDDataGridViewTextBoxColumn;
        private BD_CATELSA_MULTICABLE bD_CATELSA_MULTICABLE;
        private BD_CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private BD_CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private BD_CATELSA_MULTICABLETableAdapters.RolTableAdapter rolTableAdapter;
        private BD_CATELSA_MULTICABLETableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.ComboBox rolNameComboBox;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}