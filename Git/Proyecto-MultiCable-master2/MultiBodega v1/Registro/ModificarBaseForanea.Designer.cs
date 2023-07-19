
namespace MultiBodega_v1.Registro
{
    partial class ModificarBaseForanea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarBaseForanea));
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEliminarBF = new System.Windows.Forms.Button();
            this.BtnModificarBF = new System.Windows.Forms.Button();
            this.direccionBFTextBox = new System.Windows.Forms.TextBox();
            this.FechaRegistroBFDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lugar_ZonaBFTextBox = new System.Windows.Forms.TextBox();
            this.nombreBFTextBox = new System.Windows.Forms.TextBox();
            this.notasBFTextBox = new System.Windows.Forms.TextBox();
            this.num_TelefonoBFTextBox = new System.Windows.Forms.TextBox();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.registrarBaseForaneaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarBaseForaneaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarBaseForaneaTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.iDBFTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            direccionLabel = new System.Windows.Forms.Label();
            fechaRegistroLabel = new System.Windows.Forms.Label();
            lugar_ZonaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            iDSolicitanteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarBaseForaneaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(41, 188);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 75;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaRegistroLabel
            // 
            fechaRegistroLabel.AutoSize = true;
            fechaRegistroLabel.BackColor = System.Drawing.Color.Transparent;
            fechaRegistroLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaRegistroLabel.Location = new System.Drawing.Point(484, 144);
            fechaRegistroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaRegistroLabel.Name = "fechaRegistroLabel";
            fechaRegistroLabel.Size = new System.Drawing.Size(107, 16);
            fechaRegistroLabel.TabIndex = 77;
            fechaRegistroLabel.Text = "Fecha Registro:";
            // 
            // lugar_ZonaLabel
            // 
            lugar_ZonaLabel.AutoSize = true;
            lugar_ZonaLabel.BackColor = System.Drawing.Color.Transparent;
            lugar_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lugar_ZonaLabel.Location = new System.Drawing.Point(41, 264);
            lugar_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lugar_ZonaLabel.Name = "lugar_ZonaLabel";
            lugar_ZonaLabel.Size = new System.Drawing.Size(87, 16);
            lugar_ZonaLabel.TabIndex = 83;
            lugar_ZonaLabel.Text = "Lugar/Zona:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(41, 144);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 86;
            nombreLabel.Text = "Nombre:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(41, 306);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 88;
            notasLabel.Text = "Notas:";
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(392, 264);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 89;
            num_TelefonoLabel.Text = "Número de Teléfono:";
            // 
            // iDSolicitanteLabel
            // 
            iDSolicitanteLabel.AutoSize = true;
            iDSolicitanteLabel.BackColor = System.Drawing.Color.Transparent;
            iDSolicitanteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDSolicitanteLabel.Location = new System.Drawing.Point(41, 102);
            iDSolicitanteLabel.Name = "iDSolicitanteLabel";
            iDSolicitanteLabel.Size = new System.Drawing.Size(25, 16);
            iDSolicitanteLabel.TabIndex = 93;
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
            this.label2.Location = new System.Drawing.Point(211, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 32);
            this.label2.TabIndex = 91;
            this.label2.Text = "MODIFICAR BASE FORÁNEA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEliminarBF
            // 
            this.BtnEliminarBF.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarBF.FlatAppearance.BorderSize = 0;
            this.BtnEliminarBF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarBF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarBF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarBF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarBF.Image = global::MultiBodega_v1.Properties.Resources.eliminar1;
            this.BtnEliminarBF.Location = new System.Drawing.Point(694, 368);
            this.BtnEliminarBF.Name = "BtnEliminarBF";
            this.BtnEliminarBF.Size = new System.Drawing.Size(50, 50);
            this.BtnEliminarBF.TabIndex = 9;
            this.BtnEliminarBF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminarBF.UseVisualStyleBackColor = false;
            // 
            // BtnModificarBF
            // 
            this.BtnModificarBF.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarBF.FlatAppearance.BorderSize = 0;
            this.BtnModificarBF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnModificarBF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnModificarBF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarBF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarBF.Image = global::MultiBodega_v1.Properties.Resources.actualizar1;
            this.BtnModificarBF.Location = new System.Drawing.Point(694, 310);
            this.BtnModificarBF.Name = "BtnModificarBF";
            this.BtnModificarBF.Size = new System.Drawing.Size(50, 50);
            this.BtnModificarBF.TabIndex = 8;
            this.BtnModificarBF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificarBF.UseVisualStyleBackColor = false;
            this.BtnModificarBF.Click += new System.EventHandler(this.BtnModificarBF_Click);
            // 
            // direccionBFTextBox
            // 
            this.direccionBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionBFTextBox.Location = new System.Drawing.Point(44, 207);
            this.direccionBFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionBFTextBox.Multiline = true;
            this.direccionBFTextBox.Name = "direccionBFTextBox";
            this.direccionBFTextBox.Size = new System.Drawing.Size(616, 53);
            this.direccionBFTextBox.TabIndex = 3;
            // 
            // FechaRegistroBFDateTimePicker
            // 
            this.FechaRegistroBFDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRegistroBFDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaRegistroBFDateTimePicker.Location = new System.Drawing.Point(487, 162);
            this.FechaRegistroBFDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaRegistroBFDateTimePicker.Name = "FechaRegistroBFDateTimePicker";
            this.FechaRegistroBFDateTimePicker.Size = new System.Drawing.Size(173, 23);
            this.FechaRegistroBFDateTimePicker.TabIndex = 2;
            // 
            // lugar_ZonaBFTextBox
            // 
            this.lugar_ZonaBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_ZonaBFTextBox.Location = new System.Drawing.Point(44, 283);
            this.lugar_ZonaBFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lugar_ZonaBFTextBox.Name = "lugar_ZonaBFTextBox";
            this.lugar_ZonaBFTextBox.Size = new System.Drawing.Size(328, 23);
            this.lugar_ZonaBFTextBox.TabIndex = 4;
            // 
            // nombreBFTextBox
            // 
            this.nombreBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreBFTextBox.Location = new System.Drawing.Point(44, 163);
            this.nombreBFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreBFTextBox.Name = "nombreBFTextBox";
            this.nombreBFTextBox.Size = new System.Drawing.Size(371, 23);
            this.nombreBFTextBox.TabIndex = 1;
            // 
            // notasBFTextBox
            // 
            this.notasBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasBFTextBox.Location = new System.Drawing.Point(44, 325);
            this.notasBFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasBFTextBox.Multiline = true;
            this.notasBFTextBox.Name = "notasBFTextBox";
            this.notasBFTextBox.Size = new System.Drawing.Size(616, 88);
            this.notasBFTextBox.TabIndex = 6;
            // 
            // num_TelefonoBFTextBox
            // 
            this.num_TelefonoBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_TelefonoBFTextBox.Location = new System.Drawing.Point(395, 283);
            this.num_TelefonoBFTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_TelefonoBFTextBox.Name = "num_TelefonoBFTextBox";
            this.num_TelefonoBFTextBox.Size = new System.Drawing.Size(265, 23);
            this.num_TelefonoBFTextBox.TabIndex = 5;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrarBaseForaneaBindingSource
            // 
            this.registrarBaseForaneaBindingSource.DataMember = "RegistrarBaseForanea";
            this.registrarBaseForaneaBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // registrarBaseForaneaTableAdapter
            // 
            this.registrarBaseForaneaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = this.registrarBaseForaneaTableAdapter;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // iDBFTextBox
            // 
            this.iDBFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrarBaseForaneaBindingSource, "IDSolicitante", true));
            this.iDBFTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDBFTextBox.Location = new System.Drawing.Point(44, 121);
            this.iDBFTextBox.Name = "iDBFTextBox";
            this.iDBFTextBox.ReadOnly = true;
            this.iDBFTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDBFTextBox.TabIndex = 0;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.registrarBaseForaneaBindingSource, "Activo", true));
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(667, 162);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(77, 24);
            this.activoCheckBox.TabIndex = 7;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // ModificarBaseForanea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.ControlBox = false;
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(iDSolicitanteLabel);
            this.Controls.Add(this.iDBFTextBox);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEliminarBF);
            this.Controls.Add(this.BtnModificarBF);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionBFTextBox);
            this.Controls.Add(fechaRegistroLabel);
            this.Controls.Add(this.FechaRegistroBFDateTimePicker);
            this.Controls.Add(lugar_ZonaLabel);
            this.Controls.Add(this.lugar_ZonaBFTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreBFTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasBFTextBox);
            this.Controls.Add(num_TelefonoLabel);
            this.Controls.Add(this.num_TelefonoBFTextBox);
            this.DoubleBuffered = true;
            this.Name = "ModificarBaseForanea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Base Foranea";
            this.Load += new System.EventHandler(this.ModificarBaseForanea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarBaseForaneaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEliminarBF;
        private System.Windows.Forms.Button BtnModificarBF;
        private System.Windows.Forms.TextBox direccionBFTextBox;
        private System.Windows.Forms.DateTimePicker FechaRegistroBFDateTimePicker;
        private System.Windows.Forms.TextBox lugar_ZonaBFTextBox;
        private System.Windows.Forms.TextBox nombreBFTextBox;
        private System.Windows.Forms.TextBox notasBFTextBox;
        private System.Windows.Forms.TextBox num_TelefonoBFTextBox;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource registrarBaseForaneaBindingSource;
        private _CATELSA_MULTICABLETableAdapters.RegistrarBaseForaneaTableAdapter registrarBaseForaneaTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDBFTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
    }
}