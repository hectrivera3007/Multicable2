
namespace MultiBodega_v1.Reporte_Bodegas
{
    partial class Bodega4
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
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bodega4));
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReporteBodegas_ReporteBodega4DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteBodegas_ReporteBodega4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBodegas_ReporteBodega4DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.Color.Navy;
            fechaLabel.Location = new System.Drawing.Point(681, 138);
            fechaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(62, 19);
            fechaLabel.TabIndex = 46;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(753, 136);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(105, 23);
            this.fechaDateTimePicker.TabIndex = 47;
            // 
            // ReporteBodegas_ReporteBodega4DataGridView
            // 
            this.ReporteBodegas_ReporteBodega4DataGridView.AutoGenerateColumns = false;
            this.ReporteBodegas_ReporteBodega4DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReporteBodegas_ReporteBodega4DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ReporteBodegas_ReporteBodega4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReporteBodegas_ReporteBodega4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ReporteBodegas_ReporteBodega4DataGridView.DataSource = this.reporteBodegas_ReporteBodega4BindingSource;
            this.ReporteBodegas_ReporteBodega4DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ReporteBodegas_ReporteBodega4DataGridView.Location = new System.Drawing.Point(21, 162);
            this.ReporteBodegas_ReporteBodega4DataGridView.Name = "ReporteBodegas_ReporteBodega4DataGridView";
            this.ReporteBodegas_ReporteBodega4DataGridView.Size = new System.Drawing.Size(953, 271);
            this.ReporteBodegas_ReporteBodega4DataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDBodega";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDBodega";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contable";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contable";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fisico";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fisico";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Diferencia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Diferencia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // reporteBodegas_ReporteBodega4BindingSource
            // 
            this.reporteBodegas_ReporteBodega4BindingSource.DataSource = typeof(BL.Bodega.ReporteBodegas.ReporteBodega4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(336, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 32);
            this.label3.TabIndex = 86;
            this.label3.Text = "REPORTE DE INVENTARIO";
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
            this.BtnRegresar.Location = new System.Drawing.Point(842, 449);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(135, 39);
            this.BtnRegresar.TabIndex = 88;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Image = ((System.Drawing.Image)(resources.GetObject("printbtn.Image")));
            this.printbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printbtn.Location = new System.Drawing.Point(867, 122);
            this.printbtn.Margin = new System.Windows.Forms.Padding(4);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(107, 37);
            this.printbtn.TabIndex = 87;
            this.printbtn.Text = "Imprimir";
            this.printbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // Bodega4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 500);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReporteBodegas_ReporteBodega4DataGridView);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(fechaLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bodega4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Bodega 4 - OFICINA]";
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBodegas_ReporteBodega4DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource reporteBodegas_ReporteBodega4BindingSource;
        private System.Windows.Forms.DataGridView ReporteBodegas_ReporteBodega4DataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}