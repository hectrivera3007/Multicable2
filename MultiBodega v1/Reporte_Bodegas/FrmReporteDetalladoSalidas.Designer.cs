
namespace MultiBodega_v1
{
    partial class FrmReporteDetalladoSalidas
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
            System.Windows.Forms.Label fechaActualLabel;
            System.Windows.Forms.Label movimientoReportadoLabel;
            System.Windows.Forms.Label NombreTecnicoLabel;
            System.Windows.Forms.Label rangoFechasLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDetalladoSalidas));
            this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.movimientoReportadoTextBox = new System.Windows.Forms.TextBox();
            this.rangoFechasDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nombreProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.reporteDetalladoEntradas_InfoDataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            fechaActualLabel = new System.Windows.Forms.Label();
            movimientoReportadoLabel = new System.Windows.Forms.Label();
            NombreTecnicoLabel = new System.Windows.Forms.Label();
            rangoFechasLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaActualLabel
            // 
            fechaActualLabel.AutoSize = true;
            fechaActualLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaActualLabel.Location = new System.Drawing.Point(749, 89);
            fechaActualLabel.Name = "fechaActualLabel";
            fechaActualLabel.Size = new System.Drawing.Size(98, 16);
            fechaActualLabel.TabIndex = 1;
            fechaActualLabel.Text = "Fecha Actual:";
            // 
            // movimientoReportadoLabel
            // 
            movimientoReportadoLabel.AutoSize = true;
            movimientoReportadoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movimientoReportadoLabel.Location = new System.Drawing.Point(48, 142);
            movimientoReportadoLabel.Name = "movimientoReportadoLabel";
            movimientoReportadoLabel.Size = new System.Drawing.Size(159, 16);
            movimientoReportadoLabel.TabIndex = 3;
            movimientoReportadoLabel.Text = "Movimiento Reportado:";
            // 
            // NombreTecnicoLabel
            // 
            NombreTecnicoLabel.AutoSize = true;
            NombreTecnicoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NombreTecnicoLabel.Location = new System.Drawing.Point(270, 89);
            NombreTecnicoLabel.Name = "NombreTecnicoLabel";
            NombreTecnicoLabel.Size = new System.Drawing.Size(62, 16);
            NombreTecnicoLabel.TabIndex = 5;
            NombreTecnicoLabel.Text = "Técnico:";
            // 
            // rangoFechasLabel
            // 
            rangoFechasLabel.AutoSize = true;
            rangoFechasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rangoFechasLabel.Location = new System.Drawing.Point(48, 89);
            rangoFechasLabel.Name = "rangoFechasLabel";
            rangoFechasLabel.Size = new System.Drawing.Size(52, 16);
            rangoFechasLabel.TabIndex = 7;
            rangoFechasLabel.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(158, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 16);
            label1.TabIndex = 9;
            label1.Text = "Hasta:";
            // 
            // reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource
            // 
            this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource.DataSource = typeof(BL.Bodega.ReporteDetalladoSalidas.EncabezadofrmSalida);
            // 
            // fechaActualDateTimePicker
            // 
            this.fechaActualDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource, "FechaActual", true));
            this.fechaActualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActualDateTimePicker.Location = new System.Drawing.Point(752, 109);
            this.fechaActualDateTimePicker.Name = "fechaActualDateTimePicker";
            this.fechaActualDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.fechaActualDateTimePicker.TabIndex = 2;
            // 
            // movimientoReportadoTextBox
            // 
            this.movimientoReportadoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.movimientoReportadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource, "MovimientoReportado", true));
            this.movimientoReportadoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoReportadoTextBox.Location = new System.Drawing.Point(51, 161);
            this.movimientoReportadoTextBox.Name = "movimientoReportadoTextBox";
            this.movimientoReportadoTextBox.ReadOnly = true;
            this.movimientoReportadoTextBox.Size = new System.Drawing.Size(99, 23);
            this.movimientoReportadoTextBox.TabIndex = 4;
            this.movimientoReportadoTextBox.Text = "Solo Salidas";
            // 
            // rangoFechasDateTimePicker
            // 
            this.rangoFechasDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource, "RangoFechas", true));
            this.rangoFechasDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangoFechasDateTimePicker.Location = new System.Drawing.Point(51, 106);
            this.rangoFechasDateTimePicker.Name = "rangoFechasDateTimePicker";
            this.rangoFechasDateTimePicker.Size = new System.Drawing.Size(92, 23);
            this.rangoFechasDateTimePicker.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource, "RangoFechas", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // nombreProveedorComboBox
            // 
            this.nombreProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource, "NombreProveedor", true));
            this.nombreProveedorComboBox.FormattingEnabled = true;
            this.nombreProveedorComboBox.Location = new System.Drawing.Point(273, 108);
            this.nombreProveedorComboBox.Name = "nombreProveedorComboBox";
            this.nombreProveedorComboBox.Size = new System.Drawing.Size(204, 25);
            this.nombreProveedorComboBox.TabIndex = 11;
            // 
            // reporteDetalladoEntradas_InfoDataGridBindingSource
            // 
            this.reporteDetalladoEntradas_InfoDataGridBindingSource.DataSource = typeof(BL.Bodega.ReporteDetalladoEntradas.InfoDataGrid);
            // 
            // reporteDetalladoEntradas_InfoDataGridDataGridView
            // 
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.AutoGenerateColumns = false;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.DataSource = this.reporteDetalladoEntradas_InfoDataGridBindingSource;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Location = new System.Drawing.Point(41, 197);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Name = "reporteDetalladoEntradas_InfoDataGridDataGridView";
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Size = new System.Drawing.Size(821, 379);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 380;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CostoUnitario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Costo Unitario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(315, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "REPORTE DETALLADO DE SALIDAS";
            // 
            // FrmReporteDetalladoSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 588);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reporteDetalladoEntradas_InfoDataGridDataGridView);
            this.Controls.Add(this.nombreProveedorComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label1);
            this.Controls.Add(fechaActualLabel);
            this.Controls.Add(this.fechaActualDateTimePicker);
            this.Controls.Add(movimientoReportadoLabel);
            this.Controls.Add(this.movimientoReportadoTextBox);
            this.Controls.Add(NombreTecnicoLabel);
            this.Controls.Add(rangoFechasLabel);
            this.Controls.Add(this.rangoFechasDateTimePicker);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmReporteDetalladoSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detallado Salidas";
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteDetalladoSalidas_EncabezadofrmSalidaBindingSource;
        private System.Windows.Forms.DateTimePicker fechaActualDateTimePicker;
        private System.Windows.Forms.TextBox movimientoReportadoTextBox;
        private System.Windows.Forms.DateTimePicker rangoFechasDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox nombreProveedorComboBox;
        private System.Windows.Forms.BindingSource reporteDetalladoEntradas_InfoDataGridBindingSource;
        private System.Windows.Forms.DataGridView reporteDetalladoEntradas_InfoDataGridDataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}