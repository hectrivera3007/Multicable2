
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmRegistrarTecnico
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label num_TelefonoLabel;
            System.Windows.Forms.Label iDSolicitanteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarTecnico));
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.num_TelefonoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dNITextBox = new System.Windows.Forms.MaskedTextBox();
            this.iDSolicitanteTextBox = new System.Windows.Forms.TextBox();
            this.registrarTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarTecnicosTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarTecnicosTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            iDSolicitanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = System.Drawing.Color.Transparent;
            apellidoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(327, 151);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(68, 16);
            apellidoLabel.TabIndex = 0;
            apellidoLabel.Text = "Apellido:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(46, 196);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.BackColor = System.Drawing.Color.Transparent;
            dNILabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dNILabel.Location = new System.Drawing.Point(212, 275);
            dNILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(35, 16);
            dNILabel.TabIndex = 4;
            dNILabel.Text = "DNI:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(621, 151);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(128, 16);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha de Registro ";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.BackColor = System.Drawing.Color.Transparent;
            nombresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(46, 151);
            nombresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(64, 16);
            nombresLabel.TabIndex = 10;
            nombresLabel.Text = "Nombre:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(46, 320);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 12;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(46, 276);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 27;
            num_TelefonoLabel.Text = "Número de Telefono:";
            // 
            // iDSolicitanteLabel
            // 
            iDSolicitanteLabel.AutoSize = true;
            iDSolicitanteLabel.BackColor = System.Drawing.Color.Transparent;
            iDSolicitanteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDSolicitanteLabel.Location = new System.Drawing.Point(46, 105);
            iDSolicitanteLabel.Name = "iDSolicitanteLabel";
            iDSolicitanteLabel.Size = new System.Drawing.Size(25, 16);
            iDSolicitanteLabel.TabIndex = 73;
            iDSolicitanteLabel.Text = "ID:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(330, 169);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(272, 23);
            this.apellidoTextBox.TabIndex = 1;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(49, 214);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(553, 62);
            this.direccionTextBox.TabIndex = 3;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(624, 169);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(105, 23);
            this.fechaDateTimePicker.TabIndex = 2;
            this.fechaDateTimePicker.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(49, 169);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(265, 23);
            this.nombresTextBox.TabIndex = 0;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Location = new System.Drawing.Point(49, 338);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(553, 78);
            this.notasTextBox.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::MultiBodega_v1.Properties.Resources.Guardar_32x32;
            this.BtnGuardar.Location = new System.Drawing.Point(694, 338);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(50, 50);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(258, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 70;
            this.label2.Text = "REGISTRAR TÉCNICO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
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
            this.BtnRegresar.Location = new System.Drawing.Point(646, 418);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 41);
            this.BtnRegresar.TabIndex = 71;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(624, 196);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(70, 24);
            this.activoCheckBox.TabIndex = 7;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // num_TelefonoTextBox
            // 
            this.num_TelefonoTextBox.Location = new System.Drawing.Point(49, 293);
            this.num_TelefonoTextBox.Mask = "+000 0000 - 0000";
            this.num_TelefonoTextBox.Name = "num_TelefonoTextBox";
            this.num_TelefonoTextBox.Size = new System.Drawing.Size(159, 23);
            this.num_TelefonoTextBox.TabIndex = 72;
            // 
            // dNITextBox
            // 
            this.dNITextBox.Location = new System.Drawing.Point(215, 293);
            this.dNITextBox.Mask = "0000-0000-00000";
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(121, 23);
            this.dNITextBox.TabIndex = 73;
            // 
            // iDSolicitanteTextBox
            // 
            this.iDSolicitanteTextBox.Location = new System.Drawing.Point(49, 125);
            this.iDSolicitanteTextBox.Name = "iDSolicitanteTextBox";
            this.iDSolicitanteTextBox.ReadOnly = true;
            this.iDSolicitanteTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDSolicitanteTextBox.TabIndex = 74;
            // 
            // registrarTecnicosBindingSource
            // 
            this.registrarTecnicosBindingSource.DataMember = "RegistrarTecnicos";
            this.registrarTecnicosBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // registrarTecnicosTableAdapter
            // 
            this.registrarTecnicosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = this.registrarTecnicosTableAdapter;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // FrmRegistrarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(iDSolicitanteLabel);
            this.Controls.Add(this.iDSolicitanteTextBox);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(this.num_TelefonoTextBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(num_TelefonoLabel);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xwzz rede43<sstswgxt";
            this.Load += new System.EventHandler(this.FrmRegistrarTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegresar;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.MaskedTextBox num_TelefonoTextBox;
        private System.Windows.Forms.MaskedTextBox dNITextBox;
        private System.Windows.Forms.TextBox iDSolicitanteTextBox;
        private System.Windows.Forms.BindingSource registrarTecnicosBindingSource;
        private _CATELSA_MULTICABLETableAdapters.RegistrarTecnicosTableAdapter registrarTecnicosTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
    }
}