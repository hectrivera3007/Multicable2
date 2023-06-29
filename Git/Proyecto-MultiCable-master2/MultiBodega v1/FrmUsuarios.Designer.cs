
namespace MultiBodega_v1
{
    partial class FrmUsuarios
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.TextoBuscar = new System.Windows.Forms.TextBox();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.VistaUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.vistaUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnActualizarGrid = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaUsuarioTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.VistaUsuarioTableAdapter();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaActivacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaAsignadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 114);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 16);
            label1.TabIndex = 71;
            label1.Text = "Buscar Usuario:";
            // 
            // TextoBuscar
            // 
            this.TextoBuscar.Location = new System.Drawing.Point(13, 132);
            this.TextoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TextoBuscar.Name = "TextoBuscar";
            this.TextoBuscar.Size = new System.Drawing.Size(453, 23);
            this.TextoBuscar.TabIndex = 0;
            this.TextoBuscar.TextChanged += new System.EventHandler(this.TextoBuscar_TextChanged);
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(280, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 69;
            this.label2.Text = "LISTA DE USUARIOS";
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BajosMinimosTableAdapter = null;
            this.tableAdapterManager1.BodegaTableAdapter = null;
            this.tableAdapterManager1.ComprasTableAdapter = null;
            this.tableAdapterManager1.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DevolucionesTableAdapter = null;
            this.tableAdapterManager1.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager1.PermisosAdministradorTableAdapter = null;
            this.tableAdapterManager1.PermisosComprasTableAdapter = null;
            this.tableAdapterManager1.PermisosEncargadoBodegaTableAdapter = null;
            this.tableAdapterManager1.ProductoTableAdapter = null;
            this.tableAdapterManager1.ProveedoresTableAdapter = null;
            this.tableAdapterManager1.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager1.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager1.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager1.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager1.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager1.RolTableAdapter = null;
            this.tableAdapterManager1.TipoMaterialTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = null;
            // 
            // VistaUsuariosDataGridView
            // 
            this.VistaUsuariosDataGridView.AutoGenerateColumns = false;
            this.VistaUsuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VistaUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.dataGridViewTextBoxColumn1,
            this.FechaActivacion,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.bodegaAsignadaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.VistaUsuariosDataGridView.DataSource = this.vistaUsuarioBindingSource;
            this.VistaUsuariosDataGridView.Location = new System.Drawing.Point(-2, 162);
            this.VistaUsuariosDataGridView.Name = "VistaUsuariosDataGridView";
            this.VistaUsuariosDataGridView.ReadOnly = true;
            this.VistaUsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaUsuariosDataGridView.Size = new System.Drawing.Size(897, 220);
            this.VistaUsuariosDataGridView.TabIndex = 71;
            this.VistaUsuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vista_UsuariosDataGridView_CellContentClick_1);
            // 
            // vistaUsuarioBindingSource
            // 
            this.vistaUsuarioBindingSource.DataMember = "VistaUsuario";
            this.vistaUsuarioBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // BtnActualizarGrid
            // 
            this.BtnActualizarGrid.FlatAppearance.BorderSize = 0;
            this.BtnActualizarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarGrid.Image = global::MultiBodega_v1.Properties.Resources.actualizar__2_;
            this.BtnActualizarGrid.Location = new System.Drawing.Point(852, 119);
            this.BtnActualizarGrid.Name = "BtnActualizarGrid";
            this.BtnActualizarGrid.Size = new System.Drawing.Size(39, 40);
            this.BtnActualizarGrid.TabIndex = 72;
            this.BtnActualizarGrid.UseVisualStyleBackColor = true;
            this.BtnActualizarGrid.Click += new System.EventHandler(this.BtnActualizarGrid_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(283, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
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
            this.BtnRegresar.Location = new System.Drawing.Point(698, 388);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(131, 42);
            this.BtnRegresar.TabIndex = 67;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this._CATELSA_MULTICABLE;
            // 
            // vistaUsuarioTableAdapter
            // 
            this.vistaUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnSeleccionar.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // FechaActivacion
            // 
            this.FechaActivacion.DataPropertyName = "FechaActivacion";
            this.FechaActivacion.HeaderText = "Fecha de Activacion";
            this.FechaActivacion.Name = "FechaActivacion";
            this.FechaActivacion.ReadOnly = true;
            this.FechaActivacion.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre de Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NumTelefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Número de Teléfono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Contrasena";
            this.dataGridViewTextBoxColumn7.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ConfirmarContrasena";
            this.dataGridViewTextBoxColumn8.HeaderText = "Confirmar Contraseña";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // bodegaAsignadaDataGridViewTextBoxColumn
            // 
            this.bodegaAsignadaDataGridViewTextBoxColumn.DataPropertyName = "Bodega_Asignada";
            this.bodegaAsignadaDataGridViewTextBoxColumn.HeaderText = "Bodega Asignada";
            this.bodegaAsignadaDataGridViewTextBoxColumn.Name = "bodegaAsignadaDataGridViewTextBoxColumn";
            this.bodegaAsignadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodegaAsignadaDataGridViewTextBoxColumn.Width = 190;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RolName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre de Rol";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 190;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(915, 456);
            this.Controls.Add(this.BtnActualizarGrid);
            this.Controls.Add(this.VistaUsuariosDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TextoBuscar);
            this.Controls.Add(this.BtnRegresar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios del Sistema";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextoBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmarContrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaIDDataGridViewTextBoxColumn;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private _CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button BtnActualizarGrid;
        private System.Windows.Forms.BindingSource vistaUsuarioBindingSource;
        private _CATELSA_MULTICABLETableAdapters.VistaUsuarioTableAdapter vistaUsuarioTableAdapter;
        public System.Windows.Forms.DataGridView VistaUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaActivacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodegaAsignadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}