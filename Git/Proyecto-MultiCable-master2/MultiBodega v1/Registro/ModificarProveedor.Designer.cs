
namespace MultiBodega_v1.Registro
{
    partial class ModificarProveedor
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
            System.Windows.Forms.Label iDProveedorLabel;
            System.Windows.Forms.Label tipo_ProveedorLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label num_TelefonoLabel;
            System.Windows.Forms.Label pais_ZonaLabel;
            System.Windows.Forms.Label personaContactoLabel;
            System.Windows.Forms.Label rTNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProveedor));
            this.num_TelefonoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.tipo_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.pais_ZonaTextBox = new System.Windows.Forms.TextBox();
            this.personaContactoTextBox = new System.Windows.Forms.TextBox();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            iDProveedorLabel = new System.Windows.Forms.Label();
            tipo_ProveedorLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            pais_ZonaLabel = new System.Windows.Forms.Label();
            personaContactoLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            iDProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDProveedorLabel.Location = new System.Drawing.Point(32, 144);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(94, 16);
            iDProveedorLabel.TabIndex = 121;
            iDProveedorLabel.Text = "ID Proveedor:";
            // 
            // tipo_ProveedorLabel
            // 
            tipo_ProveedorLabel.AutoSize = true;
            tipo_ProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            tipo_ProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_ProveedorLabel.Location = new System.Drawing.Point(414, 285);
            tipo_ProveedorLabel.Name = "tipo_ProveedorLabel";
            tipo_ProveedorLabel.Size = new System.Drawing.Size(108, 16);
            tipo_ProveedorLabel.TabIndex = 118;
            tipo_ProveedorLabel.Text = "Tipo Proveedor:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.BackColor = System.Drawing.Color.Transparent;
            correoElectronicoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoElectronicoLabel.Location = new System.Drawing.Point(265, 331);
            correoElectronicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(132, 16);
            correoElectronicoLabel.TabIndex = 110;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(31, 234);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 111;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.BackColor = System.Drawing.Color.Transparent;
            nombreProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.Location = new System.Drawing.Point(31, 190);
            nombreProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(133, 16);
            nombreProveedorLabel.TabIndex = 112;
            nombreProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(32, 375);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 113;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(31, 331);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 114;
            num_TelefonoLabel.Text = "Número de Teléfono:";
            // 
            // pais_ZonaLabel
            // 
            pais_ZonaLabel.AutoSize = true;
            pais_ZonaLabel.BackColor = System.Drawing.Color.Transparent;
            pais_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pais_ZonaLabel.Location = new System.Drawing.Point(414, 234);
            pais_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pais_ZonaLabel.Name = "pais_ZonaLabel";
            pais_ZonaLabel.Size = new System.Drawing.Size(76, 16);
            pais_ZonaLabel.TabIndex = 115;
            pais_ZonaLabel.Text = "Pais/Zona:";
            // 
            // personaContactoLabel
            // 
            personaContactoLabel.AutoSize = true;
            personaContactoLabel.BackColor = System.Drawing.Color.Transparent;
            personaContactoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            personaContactoLabel.Location = new System.Drawing.Point(414, 190);
            personaContactoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            personaContactoLabel.Name = "personaContactoLabel";
            personaContactoLabel.Size = new System.Drawing.Size(126, 16);
            personaContactoLabel.TabIndex = 116;
            personaContactoLabel.Text = "Persona Contacto:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.BackColor = System.Drawing.Color.Transparent;
            rTNLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rTNLabel.Location = new System.Drawing.Point(263, 190);
            rTNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(36, 16);
            rTNLabel.TabIndex = 117;
            rTNLabel.Text = "RTN:";
            // 
            // num_TelefonoTextBox
            // 
            this.num_TelefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TelefonoTextBox.Location = new System.Drawing.Point(35, 350);
            this.num_TelefonoTextBox.Mask = "+000 0000-0000";
            this.num_TelefonoTextBox.Name = "num_TelefonoTextBox";
            this.num_TelefonoTextBox.Size = new System.Drawing.Size(212, 23);
            this.num_TelefonoTextBox.TabIndex = 101;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(615, 208);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(71, 24);
            this.activoCheckBox.TabIndex = 104;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(35, 163);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.ReadOnly = true;
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDProveedorTextBox.TabIndex = 94;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTNTextBox.Location = new System.Drawing.Point(266, 209);
            this.rTNTextBox.MaxLength = 14;
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(131, 23);
            this.rTNTextBox.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(230, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 32);
            this.label2.TabIndex = 120;
            this.label2.Text = "MODIFICAR PROVEEDOR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 119;
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
            this.BtnRegresar.Location = new System.Drawing.Point(646, 441);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 109;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // tipo_ProveedorComboBox
            // 
            this.tipo_ProveedorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.tipo_ProveedorComboBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tipo_ProveedorComboBox.FormattingEnabled = true;
            this.tipo_ProveedorComboBox.Items.AddRange(new object[] {
            "Local",
            "Extranjero"});
            this.tipo_ProveedorComboBox.Location = new System.Drawing.Point(417, 303);
            this.tipo_ProveedorComboBox.Name = "tipo_ProveedorComboBox";
            this.tipo_ProveedorComboBox.Size = new System.Drawing.Size(191, 25);
            this.tipo_ProveedorComboBox.TabIndex = 100;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::MultiBodega_v1.Properties.Resources.eliminar1;
            this.btnEliminar.Location = new System.Drawing.Point(694, 368);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 108;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Image = global::MultiBodega_v1.Properties.Resources.actualizar1;
            this.btnMod.Location = new System.Drawing.Point(694, 310);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(50, 50);
            this.btnMod.TabIndex = 107;
            this.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(266, 350);
            this.correoElectronicoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(342, 24);
            this.correoElectronicoTextBox.TabIndex = 102;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.direccionTextBox.Location = new System.Drawing.Point(34, 253);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(364, 75);
            this.direccionTextBox.TabIndex = 98;
            // 
            // nombreProveedorTextBox
            // 
            this.nombreProveedorTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nombreProveedorTextBox.Location = new System.Drawing.Point(34, 209);
            this.nombreProveedorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            this.nombreProveedorTextBox.Size = new System.Drawing.Size(213, 24);
            this.nombreProveedorTextBox.TabIndex = 95;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.notasTextBox.Location = new System.Drawing.Point(34, 394);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(574, 65);
            this.notasTextBox.TabIndex = 103;
            // 
            // pais_ZonaTextBox
            // 
            this.pais_ZonaTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.pais_ZonaTextBox.Location = new System.Drawing.Point(417, 253);
            this.pais_ZonaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pais_ZonaTextBox.Name = "pais_ZonaTextBox";
            this.pais_ZonaTextBox.Size = new System.Drawing.Size(191, 24);
            this.pais_ZonaTextBox.TabIndex = 99;
            // 
            // personaContactoTextBox
            // 
            this.personaContactoTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.personaContactoTextBox.Location = new System.Drawing.Point(417, 209);
            this.personaContactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personaContactoTextBox.Name = "personaContactoTextBox";
            this.personaContactoTextBox.Size = new System.Drawing.Size(191, 24);
            this.personaContactoTextBox.TabIndex = 97;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this._CATELSA_MULTICABLE;
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
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.ControlBox = false;
            this.Controls.Add(this.num_TelefonoTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(tipo_ProveedorLabel);
            this.Controls.Add(this.tipo_ProveedorComboBox);
            this.Controls.Add(this.btnEliminar);
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
            this.Name = "ModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMod;
        public System.Windows.Forms.TextBox iDProveedorTextBox;
        public System.Windows.Forms.TextBox nombreProveedorTextBox;
        public System.Windows.Forms.TextBox rTNTextBox;
        public System.Windows.Forms.TextBox personaContactoTextBox;
        public System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.TextBox pais_ZonaTextBox;
        public System.Windows.Forms.ComboBox tipo_ProveedorComboBox;
        public System.Windows.Forms.MaskedTextBox num_TelefonoTextBox;
        public System.Windows.Forms.TextBox correoElectronicoTextBox;
        public System.Windows.Forms.TextBox notasTextBox;
        public System.Windows.Forms.CheckBox activoCheckBox;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private _CATELSA_MULTICABLETableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
    }
}