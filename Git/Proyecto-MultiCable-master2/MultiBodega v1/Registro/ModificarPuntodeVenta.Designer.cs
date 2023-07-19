
namespace MultiBodega_v1.Registro
{
    partial class ModificarPuntodeVenta
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaRegistroLabel;
            System.Windows.Forms.Label lugar_ZonaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label num_TelefonoLabel;
            System.Windows.Forms.Label iDSolicitanteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPuntodeVenta));
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ModificarPV = new System.Windows.Forms.Button();
            this.direccionPVTextBox = new System.Windows.Forms.TextBox();
            this.fechaPVDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lugar_ZonaPVTextBox = new System.Windows.Forms.TextBox();
            this.nombrePVTextBox = new System.Windows.Forms.TextBox();
            this.notasPVTextBox = new System.Windows.Forms.TextBox();
            this.num_TelefonoPVTextBox = new System.Windows.Forms.TextBox();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.registrarPuntodeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarPuntodeVentaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarPuntodeVentaTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.iDPVTextBox = new System.Windows.Forms.TextBox();
            direccionLabel = new System.Windows.Forms.Label();
            fechaRegistroLabel = new System.Windows.Forms.Label();
            lugar_ZonaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            iDSolicitanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarPuntodeVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(51, 193);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 71;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaRegistroLabel
            // 
            fechaRegistroLabel.AutoSize = true;
            fechaRegistroLabel.BackColor = System.Drawing.Color.Transparent;
            fechaRegistroLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaRegistroLabel.Location = new System.Drawing.Point(491, 149);
            fechaRegistroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaRegistroLabel.Name = "fechaRegistroLabel";
            fechaRegistroLabel.Size = new System.Drawing.Size(107, 16);
            fechaRegistroLabel.TabIndex = 73;
            fechaRegistroLabel.Text = "Fecha Registro:";
            // 
            // lugar_ZonaLabel
            // 
            lugar_ZonaLabel.AutoSize = true;
            lugar_ZonaLabel.BackColor = System.Drawing.Color.Transparent;
            lugar_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lugar_ZonaLabel.Location = new System.Drawing.Point(345, 267);
            lugar_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lugar_ZonaLabel.Name = "lugar_ZonaLabel";
            lugar_ZonaLabel.Size = new System.Drawing.Size(87, 16);
            lugar_ZonaLabel.TabIndex = 79;
            lugar_ZonaLabel.Text = "Lugar/Zona:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(53, 149);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 82;
            nombreLabel.Text = "Nombre:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(51, 309);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 84;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(51, 266);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 85;
            num_TelefonoLabel.Text = "Número de Teléfono:";
            // 
            // iDSolicitanteLabel
            // 
            iDSolicitanteLabel.AutoSize = true;
            iDSolicitanteLabel.BackColor = System.Drawing.Color.Transparent;
            iDSolicitanteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDSolicitanteLabel.Location = new System.Drawing.Point(53, 104);
            iDSolicitanteLabel.Name = "iDSolicitanteLabel";
            iDSolicitanteLabel.Size = new System.Drawing.Size(25, 16);
            iDSolicitanteLabel.TabIndex = 90;
            iDSolicitanteLabel.Text = "ID:";
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
            this.BtnRegresar.TabIndex = 10;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(200, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 32);
            this.label2.TabIndex = 87;
            this.label2.Text = "MODIFICAR PUNTO DE VENTA";
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
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::MultiBodega_v1.Properties.Resources.eliminar1;
            this.button4.Location = new System.Drawing.Point(694, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 9;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ModificarPV
            // 
            this.ModificarPV.BackColor = System.Drawing.Color.Transparent;
            this.ModificarPV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ModificarPV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ModificarPV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificarPV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarPV.Image = global::MultiBodega_v1.Properties.Resources.actualizar1;
            this.ModificarPV.Location = new System.Drawing.Point(694, 310);
            this.ModificarPV.Name = "ModificarPV";
            this.ModificarPV.Size = new System.Drawing.Size(50, 50);
            this.ModificarPV.TabIndex = 8;
            this.ModificarPV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModificarPV.UseVisualStyleBackColor = false;
            this.ModificarPV.Click += new System.EventHandler(this.ModificarPV_Click);
            // 
            // direccionPVTextBox
            // 
            this.direccionPVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionPVTextBox.Location = new System.Drawing.Point(51, 211);
            this.direccionPVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionPVTextBox.Multiline = true;
            this.direccionPVTextBox.Name = "direccionPVTextBox";
            this.direccionPVTextBox.Size = new System.Drawing.Size(597, 53);
            this.direccionPVTextBox.TabIndex = 3;
            // 
            // fechaPVDateTimePicker
            // 
            this.fechaPVDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPVDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPVDateTimePicker.Location = new System.Drawing.Point(494, 168);
            this.fechaPVDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaPVDateTimePicker.Name = "fechaPVDateTimePicker";
            this.fechaPVDateTimePicker.Size = new System.Drawing.Size(154, 23);
            this.fechaPVDateTimePicker.TabIndex = 2;
            // 
            // lugar_ZonaPVTextBox
            // 
            this.lugar_ZonaPVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_ZonaPVTextBox.Location = new System.Drawing.Point(348, 285);
            this.lugar_ZonaPVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lugar_ZonaPVTextBox.Name = "lugar_ZonaPVTextBox";
            this.lugar_ZonaPVTextBox.Size = new System.Drawing.Size(300, 23);
            this.lugar_ZonaPVTextBox.TabIndex = 5;
            // 
            // nombrePVTextBox
            // 
            this.nombrePVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePVTextBox.Location = new System.Drawing.Point(54, 168);
            this.nombrePVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombrePVTextBox.Name = "nombrePVTextBox";
            this.nombrePVTextBox.Size = new System.Drawing.Size(378, 23);
            this.nombrePVTextBox.TabIndex = 1;
            // 
            // notasPVTextBox
            // 
            this.notasPVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasPVTextBox.Location = new System.Drawing.Point(51, 328);
            this.notasPVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasPVTextBox.Multiline = true;
            this.notasPVTextBox.Name = "notasPVTextBox";
            this.notasPVTextBox.Size = new System.Drawing.Size(597, 108);
            this.notasPVTextBox.TabIndex = 6;
            // 
            // num_TelefonoPVTextBox
            // 
            this.num_TelefonoPVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TelefonoPVTextBox.Location = new System.Drawing.Point(51, 285);
            this.num_TelefonoPVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_TelefonoPVTextBox.Name = "num_TelefonoPVTextBox";
            this.num_TelefonoPVTextBox.Size = new System.Drawing.Size(265, 23);
            this.num_TelefonoPVTextBox.TabIndex = 4;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrarPuntodeVentaBindingSource
            // 
            this.registrarPuntodeVentaBindingSource.DataMember = "RegistrarPuntodeVenta";
            this.registrarPuntodeVentaBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // registrarPuntodeVentaTableAdapter
            // 
            this.registrarPuntodeVentaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = this.registrarPuntodeVentaTableAdapter;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registrarPuntodeVentaBindingSource, "Activo", true));
            this.activoCheckBox.FlatAppearance.BorderSize = 0;
            this.activoCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(655, 166);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 7;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged_1);
            // 
            // iDPVTextBox
            // 
            this.iDPVTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDPVTextBox.Location = new System.Drawing.Point(56, 123);
            this.iDPVTextBox.Name = "iDPVTextBox";
            this.iDPVTextBox.ReadOnly = true;
            this.iDPVTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDPVTextBox.TabIndex = 0;
            // 
            // ModificarPuntodeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.ControlBox = false;
            this.Controls.Add(iDSolicitanteLabel);
            this.Controls.Add(this.iDPVTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ModificarPV);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionPVTextBox);
            this.Controls.Add(fechaRegistroLabel);
            this.Controls.Add(this.fechaPVDateTimePicker);
            this.Controls.Add(lugar_ZonaLabel);
            this.Controls.Add(this.lugar_ZonaPVTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombrePVTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasPVTextBox);
            this.Controls.Add(num_TelefonoLabel);
            this.Controls.Add(this.num_TelefonoPVTextBox);
            this.DoubleBuffered = true;
            this.Name = "ModificarPuntodeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Punto de Venta";
            this.Load += new System.EventHandler(this.ModificarPuntodeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarPuntodeVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ModificarPV;
        private System.Windows.Forms.TextBox direccionPVTextBox;
        private System.Windows.Forms.DateTimePicker fechaPVDateTimePicker;
        private System.Windows.Forms.TextBox lugar_ZonaPVTextBox;
        private System.Windows.Forms.TextBox notasPVTextBox;
        private System.Windows.Forms.TextBox num_TelefonoPVTextBox;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource registrarPuntodeVentaBindingSource;
        private _CATELSA_MULTICABLETableAdapters.RegistrarPuntodeVentaTableAdapter registrarPuntodeVentaTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox activoCheckBox;
        public System.Windows.Forms.TextBox nombrePVTextBox;
        public System.Windows.Forms.TextBox iDPVTextBox;
    }
}