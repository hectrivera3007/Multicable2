
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmListarBaseForanea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarBaseForanea));
            this.RegistrarBaseForaneaDataGridView = new System.Windows.Forms.DataGridView();
            this.registrarBaseForaneaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarBase = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.registrarBaseForaneaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarBaseForaneaTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.iDSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarZonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarBaseForaneaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarBaseForaneaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrarBaseForaneaDataGridView
            // 
            this.RegistrarBaseForaneaDataGridView.AutoGenerateColumns = false;
            this.RegistrarBaseForaneaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrarBaseForaneaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrarBaseForaneaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitanteDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.lugarZonaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.numTelefonoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.RegistrarBaseForaneaDataGridView.DataSource = this.registrarBaseForaneaBindingSource;
            this.RegistrarBaseForaneaDataGridView.Location = new System.Drawing.Point(0, 149);
            this.RegistrarBaseForaneaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarBaseForaneaDataGridView.Name = "RegistrarBaseForaneaDataGridView";
            this.RegistrarBaseForaneaDataGridView.ReadOnly = true;
            this.RegistrarBaseForaneaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegistrarBaseForaneaDataGridView.Size = new System.Drawing.Size(1023, 387);
            this.RegistrarBaseForaneaDataGridView.TabIndex = 1;
            this.RegistrarBaseForaneaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistrarBaseForaneaDataGridView_CellContentClick);
            this.RegistrarBaseForaneaDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistrarBaseForaneaDataGridView_CellContentDoubleClick);
            // 
            // registrarBaseForaneaBindingSource
            // 
            this.registrarBaseForaneaBindingSource.DataMember = "RegistrarBaseForanea";
            this.registrarBaseForaneaBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(711, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar:";
            // 
            // BuscarBase
            // 
            this.BuscarBase.Location = new System.Drawing.Point(771, 118);
            this.BuscarBase.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarBase.Name = "BuscarBase";
            this.BuscarBase.Size = new System.Drawing.Size(185, 23);
            this.BuscarBase.TabIndex = 0;
            this.BuscarBase.TextChanged += new System.EventHandler(this.BuscarBase_TextChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(963, 112);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(36, 30);
            this.Limpiar.TabIndex = 54;
            this.Limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(334, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "LISTA DE BASES FORÁNEAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
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
            this.BtnRegresar.Location = new System.Drawing.Point(867, 566);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 41);
            this.BtnRegresar.TabIndex = 75;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
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
            this.tableAdapterManager.RegistrarBaseForaneaTableAdapter = this.registrarBaseForaneaTableAdapter;
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // iDSolicitanteDataGridViewTextBoxColumn
            // 
            this.iDSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "IDSolicitante";
            this.iDSolicitanteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDSolicitanteDataGridViewTextBoxColumn.Name = "iDSolicitanteDataGridViewTextBoxColumn";
            this.iDSolicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSolicitanteDataGridViewTextBoxColumn.Width = 40;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha de Registro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 220;
            // 
            // lugarZonaDataGridViewTextBoxColumn
            // 
            this.lugarZonaDataGridViewTextBoxColumn.DataPropertyName = "Lugar_Zona";
            this.lugarZonaDataGridViewTextBoxColumn.HeaderText = "Lugar/Zona";
            this.lugarZonaDataGridViewTextBoxColumn.Name = "lugarZonaDataGridViewTextBoxColumn";
            this.lugarZonaDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 250;
            // 
            // numTelefonoDataGridViewTextBoxColumn
            // 
            this.numTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.HeaderText = "Número de Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn.Name = "numTelefonoDataGridViewTextBoxColumn";
            this.numTelefonoDataGridViewTextBoxColumn.Width = 180;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.Width = 300;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.Width = 80;
            // 
            // FrmListarBaseForanea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.BuscarBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistrarBaseForaneaDataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmListarBaseForanea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Base Foranea";
            this.Load += new System.EventHandler(this.FrmListarBaseForanea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarBaseForaneaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarBaseForaneaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RegistrarBaseForaneaDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuscarBase;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegresar;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource registrarBaseForaneaBindingSource;
        private _CATELSA_MULTICABLETableAdapters.RegistrarBaseForaneaTableAdapter registrarBaseForaneaTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarZonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}