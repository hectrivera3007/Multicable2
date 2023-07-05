
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmListarPuntodeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarPuntodeVenta));
            this.RegistrarPuntodeVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPuntos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.registrarPuntodeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarPuntodeVentaTableAdapter = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RegistrarPuntodeVentaTableAdapter();
            this.tableAdapterManager = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.iDSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarZonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarPuntodeVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarPuntodeVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistrarPuntodeVentaDataGridView
            // 
            this.RegistrarPuntodeVentaDataGridView.AutoGenerateColumns = false;
            this.RegistrarPuntodeVentaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistrarPuntodeVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrarPuntodeVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitanteDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.lugarZonaDataGridViewTextBoxColumn,
            this.direcciónDataGridViewTextBoxColumn,
            this.numTelefonoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.RegistrarPuntodeVentaDataGridView.DataSource = this.registrarPuntodeVentaBindingSource;
            this.RegistrarPuntodeVentaDataGridView.Location = new System.Drawing.Point(0, 149);
            this.RegistrarPuntodeVentaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarPuntodeVentaDataGridView.Name = "RegistrarPuntodeVentaDataGridView";
            this.RegistrarPuntodeVentaDataGridView.ReadOnly = true;
            this.RegistrarPuntodeVentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegistrarPuntodeVentaDataGridView.Size = new System.Drawing.Size(1023, 387);
            this.RegistrarPuntodeVentaDataGridView.TabIndex = 51;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Transparent;
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
            this.label2.Location = new System.Drawing.Point(717, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Buscar:";
            // 
            // BuscarPuntos
            // 
            this.BuscarPuntos.Location = new System.Drawing.Point(775, 118);
            this.BuscarPuntos.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarPuntos.Name = "BuscarPuntos";
            this.BuscarPuntos.Size = new System.Drawing.Size(185, 23);
            this.BuscarPuntos.TabIndex = 0;
            this.BuscarPuntos.TextChanged += new System.EventHandler(this.BuscarPuntos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(330, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "LISTA DE PUNTOS DE VENTA";
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
            this.pictureBox2.TabIndex = 69;
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
            this.BtnRegresar.Location = new System.Drawing.Point(867, 566);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
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
            this.tableAdapterManager.RegistrarPuntodeVentaTableAdapter = this.registrarPuntodeVentaTableAdapter;
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
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaRegistroDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // lugarZonaDataGridViewTextBoxColumn
            // 
            this.lugarZonaDataGridViewTextBoxColumn.DataPropertyName = "Lugar_Zona";
            this.lugarZonaDataGridViewTextBoxColumn.HeaderText = "Lugar/Zona";
            this.lugarZonaDataGridViewTextBoxColumn.Name = "lugarZonaDataGridViewTextBoxColumn";
            this.lugarZonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lugarZonaDataGridViewTextBoxColumn.Width = 250;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            this.direcciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            this.direcciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.direcciónDataGridViewTextBoxColumn.Width = 350;
            // 
            // numTelefonoDataGridViewTextBoxColumn
            // 
            this.numTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.HeaderText = "Número de Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn.Name = "numTelefonoDataGridViewTextBoxColumn";
            this.numTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTelefonoDataGridViewTextBoxColumn.Width = 180;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Width = 300;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 80;
            // 
            // FrmListarPuntodeVenta
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarPuntos);
            this.Controls.Add(this.RegistrarPuntodeVentaDataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmListarPuntodeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Punto de Venta";
            this.Load += new System.EventHandler(this.FrmListarPuntodeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarPuntodeVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarPuntodeVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RegistrarPuntodeVentaDataGridView;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuscarPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnRegresar;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource registrarPuntodeVentaBindingSource;
        private _CATELSA_MULTICABLETableAdapters.RegistrarPuntodeVentaTableAdapter registrarPuntodeVentaTableAdapter;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSolicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarZonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}