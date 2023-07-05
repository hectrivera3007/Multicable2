
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmListarTecnicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarTecnicos));
            this.ListarTecnicosDataGridView = new System.Windows.Forms.DataGridView();
            this.iDSolicitanteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequisaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.registrarTecnicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.registrarTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarTecnico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.registro_RegistrarTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrarTecnicosTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarTecnicosTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ListarTecnicosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListarTecnicosDataGridView
            // 
            this.ListarTecnicosDataGridView.AutoGenerateColumns = false;
            this.ListarTecnicosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListarTecnicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarTecnicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitanteDataGridViewTextBoxColumn2,
            this.fechaRegistroDataGridViewTextBoxColumn2,
            this.nombresDataGridViewTextBoxColumn2,
            this.apellidosDataGridViewTextBoxColumn1,
            this.dNIDataGridViewTextBoxColumn2,
            this.direccionDataGridViewTextBoxColumn2,
            this.numTelefonoDataGridViewTextBoxColumn2,
            this.RequisaID,
            this.notasDataGridViewTextBoxColumn2,
            this.activoDataGridViewCheckBoxColumn});
            this.ListarTecnicosDataGridView.DataSource = this.registrarTecnicosBindingSource1;
            this.ListarTecnicosDataGridView.Location = new System.Drawing.Point(0, 149);
            this.ListarTecnicosDataGridView.Name = "ListarTecnicosDataGridView";
            this.ListarTecnicosDataGridView.ReadOnly = true;
            this.ListarTecnicosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarTecnicosDataGridView.Size = new System.Drawing.Size(1023, 387);
            this.ListarTecnicosDataGridView.TabIndex = 51;
            this.ListarTecnicosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListarTecnicosDataGridView_CellContentClick);
            this.ListarTecnicosDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListarTecnicosDataGridView_CellContentDoubleClick);
            // 
            // iDSolicitanteDataGridViewTextBoxColumn2
            // 
            this.iDSolicitanteDataGridViewTextBoxColumn2.DataPropertyName = "IDSolicitante";
            this.iDSolicitanteDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDSolicitanteDataGridViewTextBoxColumn2.Name = "iDSolicitanteDataGridViewTextBoxColumn2";
            this.iDSolicitanteDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDSolicitanteDataGridViewTextBoxColumn2.Width = 40;
            // 
            // fechaRegistroDataGridViewTextBoxColumn2
            // 
            this.fechaRegistroDataGridViewTextBoxColumn2.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn2.HeaderText = "Fecha de Registro";
            this.fechaRegistroDataGridViewTextBoxColumn2.Name = "fechaRegistroDataGridViewTextBoxColumn2";
            this.fechaRegistroDataGridViewTextBoxColumn2.ReadOnly = true;
            this.fechaRegistroDataGridViewTextBoxColumn2.Width = 150;
            // 
            // nombresDataGridViewTextBoxColumn2
            // 
            this.nombresDataGridViewTextBoxColumn2.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn2.Name = "nombresDataGridViewTextBoxColumn2";
            this.nombresDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn2.Width = 180;
            // 
            // apellidosDataGridViewTextBoxColumn1
            // 
            this.apellidosDataGridViewTextBoxColumn1.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.Name = "apellidosDataGridViewTextBoxColumn1";
            this.apellidosDataGridViewTextBoxColumn1.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn1.Width = 180;
            // 
            // dNIDataGridViewTextBoxColumn2
            // 
            this.dNIDataGridViewTextBoxColumn2.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn2.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn2.Name = "dNIDataGridViewTextBoxColumn2";
            this.dNIDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dNIDataGridViewTextBoxColumn2.Width = 140;
            // 
            // direccionDataGridViewTextBoxColumn2
            // 
            this.direccionDataGridViewTextBoxColumn2.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn2.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn2.Name = "direccionDataGridViewTextBoxColumn2";
            this.direccionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn2.Width = 300;
            // 
            // numTelefonoDataGridViewTextBoxColumn2
            // 
            this.numTelefonoDataGridViewTextBoxColumn2.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn2.HeaderText = "Número de Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn2.Name = "numTelefonoDataGridViewTextBoxColumn2";
            this.numTelefonoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.numTelefonoDataGridViewTextBoxColumn2.Width = 180;
            // 
            // RequisaID
            // 
            this.RequisaID.DataPropertyName = "RequisaID";
            this.RequisaID.HeaderText = "RequisaID";
            this.RequisaID.Name = "RequisaID";
            this.RequisaID.ReadOnly = true;
            this.RequisaID.Visible = false;
            // 
            // notasDataGridViewTextBoxColumn2
            // 
            this.notasDataGridViewTextBoxColumn2.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn2.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn2.Name = "notasDataGridViewTextBoxColumn2";
            this.notasDataGridViewTextBoxColumn2.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn2.Width = 300;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // registrarTecnicosBindingSource1
            // 
            this.registrarTecnicosBindingSource1.DataMember = "RegistrarTecnicos";
            this.registrarTecnicosBindingSource1.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrarTecnicosBindingSource
            // 
            this.registrarTecnicosBindingSource.DataMember = "RegistrarTecnicos";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatAppearance.BorderSize = 0;
            this.Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(967, 112);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(36, 30);
            this.Limpiar.TabIndex = 55;
            this.Limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(732, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Filtrar Técnicos";
            // 
            // BuscarTecnico
            // 
            this.BuscarTecnico.Location = new System.Drawing.Point(735, 118);
            this.BuscarTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarTecnico.Name = "BuscarTecnico";
            this.BuscarTecnico.Size = new System.Drawing.Size(225, 23);
            this.BuscarTecnico.TabIndex = 0;
            this.BuscarTecnico.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(381, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "LISTA DE TÉCNICOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 71;
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
            this.BtnRegresar.Location = new System.Drawing.Point(875, 564);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 73;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // registro_RegistrarTecnicosBindingSource
            // 
            this.registro_RegistrarTecnicosBindingSource.DataSource = typeof(BL.Bodega.Registrar.Registro.RegistrarTecnicos);
            // 
            // iDSolicitanteDataGridViewTextBoxColumn
            // 
            this.iDSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "IDSolicitante";
            this.iDSolicitanteDataGridViewTextBoxColumn.HeaderText = "IDSolicitante";
            this.iDSolicitanteDataGridViewTextBoxColumn.Name = "iDSolicitanteDataGridViewTextBoxColumn";
            this.iDSolicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // numTelefonoDataGridViewTextBoxColumn
            // 
            this.numTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.HeaderText = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.Name = "numTelefonoDataGridViewTextBoxColumn";
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
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
            this.tableAdapterManager.RegistrarTecnicosTableAdapter = this.registrarTecnicosTableAdapter;
            this.tableAdapterManager.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.TipoMaterialTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // FrmListarTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarTecnico);
            this.Controls.Add(this.ListarTecnicosDataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Tecnicos";
            this.Load += new System.EventHandler(this.FrmListarTecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarTecnicosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ListarTecnicosDataGridView;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuscarTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.BindingSource registro_RegistrarTecnicosBindingSource;
        private System.Windows.Forms.BindingSource registrarTecnicosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn1;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource registrarTecnicosBindingSource1;
        private _CATELSA_MULTICABLETableAdapters.RegistrarTecnicosTableAdapter registrarTecnicosTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitanteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequisaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}