
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
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.label2 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.vista_UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_UsuariosTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.Vista_UsuariosTableAdapter();
            this.Vista_UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnActualizarGrid = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_UsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(13, 132);
            this.Txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(453, 23);
            this.Txtbuscar.TabIndex = 0;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged);
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this._CATELSA_MULTICABLE;
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
            this.tableAdapterManager1.ProductosTableAdapter = null;
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
            // vista_UsuariosBindingSource
            // 
            this.vista_UsuariosBindingSource.DataMember = "Vista_Usuarios";
            this.vista_UsuariosBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // vista_UsuariosTableAdapter
            // 
            this.vista_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Vista_UsuariosDataGridView
            // 
            this.Vista_UsuariosDataGridView.AutoGenerateColumns = false;
            this.Vista_UsuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vista_UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vista_UsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnSeleccionar,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewCheckBoxColumn2});
            this.Vista_UsuariosDataGridView.DataSource = this.vista_UsuariosBindingSource;
            this.Vista_UsuariosDataGridView.Location = new System.Drawing.Point(-2, 162);
            this.Vista_UsuariosDataGridView.Name = "Vista_UsuariosDataGridView";
            this.Vista_UsuariosDataGridView.ReadOnly = true;
            this.Vista_UsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Vista_UsuariosDataGridView.Size = new System.Drawing.Size(897, 220);
            this.Vista_UsuariosDataGridView.TabIndex = 71;
            this.Vista_UsuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vista_UsuariosDataGridView_CellContentClick_1);
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
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.HeaderText = "";
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.ReadOnly = true;
            this.BtnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnSeleccionar.Width = 30;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 220;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NombreUsuario";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nombre de Usuario";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 180;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NumTelefono";
            this.dataGridViewTextBoxColumn12.HeaderText = "Número de Teléfono";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Contrasena";
            this.dataGridViewTextBoxColumn13.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ConfirmarContrasena";
            this.dataGridViewTextBoxColumn14.HeaderText = "Confirmar Contraseña";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 225;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Bodega_Asignada";
            this.dataGridViewTextBoxColumn15.HeaderText = "Bodega Asignada";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 225;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "RolName";
            this.dataGridViewTextBoxColumn16.HeaderText = "Nombre de Rol";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(915, 456);
            this.Controls.Add(this.BtnActualizarGrid);
            this.Controls.Add(this.Vista_UsuariosDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Txtbuscar);
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
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_UsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txtbuscar;
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
        private System.Windows.Forms.BindingSource vista_UsuariosBindingSource;
        private _CATELSA_MULTICABLETableAdapters.Vista_UsuariosTableAdapter vista_UsuariosTableAdapter;
        private System.Windows.Forms.DataGridView Vista_UsuariosDataGridView;
        private System.Windows.Forms.Button BtnActualizarGrid;
        private System.Windows.Forms.DataGridViewButtonColumn BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}