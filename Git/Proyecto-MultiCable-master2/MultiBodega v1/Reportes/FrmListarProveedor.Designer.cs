
namespace MultiBodega_v1.Inventario
{
    partial class FrmListarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarProveedor));
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedores1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarProveedor = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.rTNDataGridViewTextBoxColumn,
            this.personaContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.Pais_Zona,
            this.tipoProveedorDataGridViewTextBoxColumn,
            this.numTelefonoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.proveedoresDataGridView.DataSource = this.proveedores1BindingSource;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(0, 149);
            this.proveedoresDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.Size = new System.Drawing.Size(1023, 387);
            this.proveedoresDataGridView.TabIndex = 1;
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProveedorDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            this.rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            this.rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNDataGridViewTextBoxColumn.MinimumWidth = 14;
            this.rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            this.rTNDataGridViewTextBoxColumn.Width = 150;
            // 
            // personaContactoDataGridViewTextBoxColumn
            // 
            this.personaContactoDataGridViewTextBoxColumn.DataPropertyName = "PersonaContacto";
            this.personaContactoDataGridViewTextBoxColumn.HeaderText = "Persona Contacto";
            this.personaContactoDataGridViewTextBoxColumn.Name = "personaContactoDataGridViewTextBoxColumn";
            this.personaContactoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 200;
            // 
            // Pais_Zona
            // 
            this.Pais_Zona.DataPropertyName = "Pais_Zona";
            this.Pais_Zona.HeaderText = "Pais/Zona";
            this.Pais_Zona.Name = "Pais_Zona";
            // 
            // tipoProveedorDataGridViewTextBoxColumn
            // 
            this.tipoProveedorDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Proveedor";
            this.tipoProveedorDataGridViewTextBoxColumn.HeaderText = "Tipo de Proveedor";
            this.tipoProveedorDataGridViewTextBoxColumn.Name = "tipoProveedorDataGridViewTextBoxColumn";
            // 
            // numTelefonoDataGridViewTextBoxColumn
            // 
            this.numTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn.HeaderText = "Número de Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn.Name = "numTelefonoDataGridViewTextBoxColumn";
            this.numTelefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.Width = 200;
            // 
            // proveedores1BindingSource
            // 
            this.proveedores1BindingSource.DataMember = "Proveedores1";
            // 
            // _CATELSA_MULTICABLEDataSet
            // 
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(967, 111);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(36, 30);
            this.BtnLimpiar.TabIndex = 47;
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(731, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Filtrar Proveedor";
            // 
            // BuscarProveedor
            // 
            this.BuscarProveedor.Location = new System.Drawing.Point(734, 117);
            this.BuscarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarProveedor.Name = "BuscarProveedor";
            this.BuscarProveedor.Size = new System.Drawing.Size(226, 23);
            this.BuscarProveedor.TabIndex = 0;
            this.BuscarProveedor.TextChanged += new System.EventHandler(this.BuscarProveedor_TextChanged);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(867, 566);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 63;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(353, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 68;
            this.label1.Text = "LISTA DE PROVEEDORES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // proveedores1TableAdapter
            // 
            // 
            // tableAdapterManager
            // 
            // 
            // FrmListarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarProveedor);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Proveedores";
            this.Load += new System.EventHandler(this.FrmListarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuscarProveedor;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource proveedores1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
    }
}