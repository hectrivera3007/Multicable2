
namespace MultiBodega_v1.Bodegas
{
    partial class Bodega1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bodega1));
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reporteBodegas_ReporteBodega1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteBodegas_ReporteBodega1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(683, 138);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(62, 19);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(753, 136);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(106, 23);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // reporteBodegas_ReporteBodega1BindingSource
            // 
            this.reporteBodegas_ReporteBodega1BindingSource.DataSource = typeof(BL.Bodega.ReporteBodegas.ReporteBodega1);
            // 
            // reporteBodegas_ReporteBodega1DataGridView
            // 
            this.reporteBodegas_ReporteBodega1DataGridView.AutoGenerateColumns = false;
            this.reporteBodegas_ReporteBodega1DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reporteBodegas_ReporteBodega1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteBodegas_ReporteBodega1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.reporteBodegas_ReporteBodega1DataGridView.DataSource = this.reporteBodegas_ReporteBodega1BindingSource;
            this.reporteBodegas_ReporteBodega1DataGridView.Location = new System.Drawing.Point(21, 162);
            this.reporteBodegas_ReporteBodega1DataGridView.Name = "reporteBodegas_ReporteBodega1DataGridView";
            this.reporteBodegas_ReporteBodega1DataGridView.Size = new System.Drawing.Size(953, 271);
            this.reporteBodegas_ReporteBodega1DataGridView.TabIndex = 41;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 400;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn11.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Contable";
            this.dataGridViewTextBoxColumn12.HeaderText = "Contable";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Fisico";
            this.dataGridViewTextBoxColumn13.HeaderText = "Fisico";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Diferencia";
            this.dataGridViewTextBoxColumn14.HeaderText = "Diferencia";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.printbtn.TabIndex = 50;
            this.printbtn.Text = "Imprimir";
            this.printbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printbtn.UseVisualStyleBackColor = false;
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
            this.label3.TabIndex = 80;
            this.label3.Text = "REPORTE DE INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
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
            this.BtnRegresar.Location = new System.Drawing.Point(842, 448);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(135, 39);
            this.BtnRegresar.TabIndex = 81;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Bodega1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 499);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.reporteBodegas_ReporteBodega1DataGridView);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Bodega1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Bodega 1 - CATELSA ABAJO]";
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBodegas_ReporteBodega1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource reporteBodegas_ReporteBodega1BindingSource;
        private System.Windows.Forms.DataGridView reporteBodegas_ReporteBodega1DataGridView;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}