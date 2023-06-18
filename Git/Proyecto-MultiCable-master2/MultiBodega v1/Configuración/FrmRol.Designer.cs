
namespace MultiBodega_v1
{
    partial class FrmRol
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label rolNameLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRol));
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.rolNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rolDataGridView = new System.Windows.Forms.DataGridView();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CATELSA_MULTICABLE = new MultiBodega_v1._CATELSA_MULTICABLE();
            this.rolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rolTableAdapter1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.RolTableAdapter();
            this.tableAdapterManager1 = new MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            rolNameLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(21, 146);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 16);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // rolNameLabel
            // 
            rolNameLabel.AutoSize = true;
            rolNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolNameLabel.Location = new System.Drawing.Point(107, 146);
            rolNameLabel.Name = "rolNameLabel";
            rolNameLabel.Size = new System.Drawing.Size(109, 16);
            rolNameLabel.TabIndex = 4;
            rolNameLabel.Text = "Nombre de Rol:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(284, 146);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(53, 16);
            activoLabel.TabIndex = 108;
            activoLabel.Text = "Activo:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iDTextBox.Location = new System.Drawing.Point(24, 167);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(80, 21);
            this.iDTextBox.TabIndex = 3;
            // 
            // rolNameTextBox
            // 
            this.rolNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolNameTextBox.Location = new System.Drawing.Point(110, 167);
            this.rolNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rolNameTextBox.Name = "rolNameTextBox";
            this.rolNameTextBox.Size = new System.Drawing.Size(172, 24);
            this.rolNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(89, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 85;
            this.label1.Text = "NUEVO ROL DE USUARIO";
            // 
            // rolDataGridView
            // 
            this.rolDataGridView.AutoGenerateColumns = false;
            this.rolDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.RolID,
            this.rolNameDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.rolDataGridView.DataSource = this.rolBindingSource;
            this.rolDataGridView.Location = new System.Drawing.Point(-3, 197);
            this.rolDataGridView.Name = "rolDataGridView";
            this.rolDataGridView.Size = new System.Drawing.Size(543, 212);
            this.rolDataGridView.TabIndex = 108;
            this.rolDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolDataGridView_CellContentClick);
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this._CATELSA_MULTICABLE;
            // 
            // _CATELSA_MULTICABLE
            // 
            this._CATELSA_MULTICABLE.DataSetName = "CATELSA-MULTICABLE";
            this._CATELSA_MULTICABLE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolBindingSource1
            // 
            this.rolBindingSource1.DataSource = this._CATELSA_MULTICABLE;
            this.rolBindingSource1.Position = 0;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.Location = new System.Drawing.Point(288, 168);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(20, 24);
            this.activoCheckBox.TabIndex = 109;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackgroundImage = global::MultiBodega_v1.Properties.Resources.actualizar;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnActualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnActualizar.Location = new System.Drawing.Point(455, 163);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(36, 30);
            this.BtnActualizar.TabIndex = 111;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnNuevo.Image = global::MultiBodega_v1.Properties.Resources.Agregar_20x20;
            this.BtnNuevo.Location = new System.Drawing.Point(338, 163);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(36, 30);
            this.BtnNuevo.TabIndex = 110;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(364, 423);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 107;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::MultiBodega_v1.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Location = new System.Drawing.Point(416, 163);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 30);
            this.btnEliminar.TabIndex = 106;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.Image = global::MultiBodega_v1.Properties.Resources.Guardar_20x20;
            this.btnGuardar.Location = new System.Drawing.Point(377, 163);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 30);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // rolTableAdapter1
            // 
            this.rolTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AjusteInventarioTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BajosMinimosTableAdapter = null;
            this.tableAdapterManager1.BodegaTableAdapter = null;
            this.tableAdapterManager1.ComprasTableAdapter = null;
            this.tableAdapterManager1.ComprobanteEntregaTableAdapter = null;
            this.tableAdapterManager1.DevolucionesTableAdapter = null;
            this.tableAdapterManager1.InventarioBodega1TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega2TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega3TableAdapter = null;
            this.tableAdapterManager1.InventarioBodega4TableAdapter = null;
            this.tableAdapterManager1.PermisosAdministradorTableAdapter = null;
            this.tableAdapterManager1.PermisosComprasTableAdapter = null;
            this.tableAdapterManager1.PermisosEncargadoBodegaTableAdapter = null;
            this.tableAdapterManager1.ProveedoresTableAdapter = null;
            this.tableAdapterManager1.RegistrarBaseForaneaTableAdapter = null;
            this.tableAdapterManager1.RegistrarPuntodeVentaTableAdapter = null;
            this.tableAdapterManager1.RegistrarTecnicosTableAdapter = null;
            this.tableAdapterManager1.RequisaEntradaTableAdapter = null;
            this.tableAdapterManager1.RequisaSalidaTableAdapter = null;
            this.tableAdapterManager1.RolTableAdapter = this.rolTableAdapter1;
            this.tableAdapterManager1.TipoMaterialTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MultiBodega_v1._CATELSA_MULTICABLETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuarioTableAdapter = null;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Width = 35;
            // 
            // RolID
            // 
            this.RolID.DataPropertyName = "RolID";
            this.RolID.HeaderText = "RolID";
            this.RolID.Name = "RolID";
            this.RolID.ReadOnly = true;
            this.RolID.Width = 40;
            // 
            // rolNameDataGridViewTextBoxColumn
            // 
            this.rolNameDataGridViewTextBoxColumn.DataPropertyName = "RolName";
            this.rolNameDataGridViewTextBoxColumn.HeaderText = "RolName";
            this.rolNameDataGridViewTextBoxColumn.Name = "rolNameDataGridViewTextBoxColumn";
            this.rolNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            // 
            // FrmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(535, 482);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.rolDataGridView);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(rolNameLabel);
            this.Controls.Add(this.rolNameTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Nuevo Rol";
            this.Load += new System.EventHandler(this.FrmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CATELSA_MULTICABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox rolNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnRegresar;
        
        private System.Windows.Forms.DataGridView rolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        private _CATELSA_MULTICABLE _CATELSA_MULTICABLE;
        private System.Windows.Forms.BindingSource rolBindingSource1;
        private _CATELSA_MULTICABLETableAdapters.RolTableAdapter rolTableAdapter1;
        private _CATELSA_MULTICABLETableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}