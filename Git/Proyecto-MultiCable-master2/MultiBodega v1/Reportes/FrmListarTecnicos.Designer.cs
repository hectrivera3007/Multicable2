
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
            this.registro_RegistrarTecnicosDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarTecnico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.registro_RegistrarTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrarTecnicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSolicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSolicitanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefonoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registro_RegistrarTecnicosDataGridView
            // 
            this.registro_RegistrarTecnicosDataGridView.AutoGenerateColumns = false;
            this.registro_RegistrarTecnicosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registro_RegistrarTecnicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registro_RegistrarTecnicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSolicitanteDataGridViewTextBoxColumn1,
            this.fechaRegistroDataGridViewTextBoxColumn1,
            this.nombresDataGridViewTextBoxColumn1,
            this.Apellidos,
            this.dNIDataGridViewTextBoxColumn1,
            this.direccionDataGridViewTextBoxColumn1,
            this.numTelefonoDataGridViewTextBoxColumn1,
            this.notasDataGridViewTextBoxColumn1});
            this.registro_RegistrarTecnicosDataGridView.DataSource = this.registrarTecnicosBindingSource;
            this.registro_RegistrarTecnicosDataGridView.Location = new System.Drawing.Point(-1, 149);
            this.registro_RegistrarTecnicosDataGridView.Name = "registro_RegistrarTecnicosDataGridView";
            this.registro_RegistrarTecnicosDataGridView.Size = new System.Drawing.Size(1028, 323);
            this.registro_RegistrarTecnicosDataGridView.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(967, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 30);
            this.button2.TabIndex = 55;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(867, 488);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 73;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // registro_RegistrarTecnicosBindingSource
            // 
            this.registro_RegistrarTecnicosBindingSource.DataSource = typeof(BL.Bodega.Registrar.Registro.RegistrarTecnicos);
            // 
            // _CATELSA_MULTICABLEDataSet
            // 
            // 
            // registrarTecnicosBindingSource
            // 
            this.registrarTecnicosBindingSource.DataMember = "RegistrarTecnicos";
            // 
            // registrarTecnicosTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
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
            // iDSolicitanteDataGridViewTextBoxColumn1
            // 
            this.iDSolicitanteDataGridViewTextBoxColumn1.DataPropertyName = "IDSolicitante";
            this.iDSolicitanteDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDSolicitanteDataGridViewTextBoxColumn1.Name = "iDSolicitanteDataGridViewTextBoxColumn1";
            this.iDSolicitanteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDSolicitanteDataGridViewTextBoxColumn1.Width = 40;
            // 
            // fechaRegistroDataGridViewTextBoxColumn1
            // 
            this.fechaRegistroDataGridViewTextBoxColumn1.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn1.HeaderText = "Fecha de Registro";
            this.fechaRegistroDataGridViewTextBoxColumn1.Name = "fechaRegistroDataGridViewTextBoxColumn1";
            this.fechaRegistroDataGridViewTextBoxColumn1.Width = 148;
            // 
            // nombresDataGridViewTextBoxColumn1
            // 
            this.nombresDataGridViewTextBoxColumn1.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn1.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn1.Name = "nombresDataGridViewTextBoxColumn1";
            this.nombresDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // dNIDataGridViewTextBoxColumn1
            // 
            this.dNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn1.Name = "dNIDataGridViewTextBoxColumn1";
            // 
            // direccionDataGridViewTextBoxColumn1
            // 
            this.direccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn1.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn1.Name = "direccionDataGridViewTextBoxColumn1";
            this.direccionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // numTelefonoDataGridViewTextBoxColumn1
            // 
            this.numTelefonoDataGridViewTextBoxColumn1.DataPropertyName = "Num_Telefono";
            this.numTelefonoDataGridViewTextBoxColumn1.HeaderText = "Número de Teléfono";
            this.numTelefonoDataGridViewTextBoxColumn1.Name = "numTelefonoDataGridViewTextBoxColumn1";
            this.numTelefonoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // notasDataGridViewTextBoxColumn1
            // 
            this.notasDataGridViewTextBoxColumn1.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn1.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn1.Name = "notasDataGridViewTextBoxColumn1";
            // 
            // FrmListarTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1023, 538);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarTecnico);
            this.Controls.Add(this.registro_RegistrarTecnicosDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Tecnicos";
            this.Load += new System.EventHandler(this.FrmListarTecnicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarTecnicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrarTecnicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView registro_RegistrarTecnicosDataGridView;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefonoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn1;
    }
}