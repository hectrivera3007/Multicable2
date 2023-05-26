
namespace MultiBodega_v1.Reporte_Bodegas
{
    partial class FrmReporteDetalladoEntradas
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
            System.Windows.Forms.Label nombreProveedorLabel;
            System.Windows.Forms.Label rangoFechasLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDetalladoEntradas));
            this.fechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.movimientoReportadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.rangoFechasDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CkOcultarPrecios = new System.Windows.Forms.CheckBox();
            this.reporteDetalladoEntradas_EncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDetalladoEntradas_InfoDataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar = new System.Windows.Forms.Button();
            fechaActualLabel = new System.Windows.Forms.Label();
            movimientoReportadoLabel = new System.Windows.Forms.Label();
            nombreProveedorLabel = new System.Windows.Forms.Label();
            rangoFechasLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_EncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaActualLabel
            // 
            fechaActualLabel.AutoSize = true;
            fechaActualLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaActualLabel.Location = new System.Drawing.Point(1079, 89);
            fechaActualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaActualLabel.Name = "fechaActualLabel";
            fechaActualLabel.Size = new System.Drawing.Size(98, 16);
            fechaActualLabel.TabIndex = 1;
            fechaActualLabel.Text = "Fecha Actual:";
            // 
            // movimientoReportadoLabel
            // 
            movimientoReportadoLabel.AutoSize = true;
            movimientoReportadoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movimientoReportadoLabel.Location = new System.Drawing.Point(457, 89);
            movimientoReportadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            movimientoReportadoLabel.Name = "movimientoReportadoLabel";
            movimientoReportadoLabel.Size = new System.Drawing.Size(159, 16);
            movimientoReportadoLabel.TabIndex = 3;
            movimientoReportadoLabel.Text = "Movimiento Reportado:";
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreProveedorLabel.Location = new System.Drawing.Point(301, 89);
            nombreProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new System.Drawing.Size(77, 16);
            nombreProveedorLabel.TabIndex = 5;
            nombreProveedorLabel.Text = "Proveedor:";
            // 
            // rangoFechasLabel
            // 
            rangoFechasLabel.AutoSize = true;
            rangoFechasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rangoFechasLabel.Location = new System.Drawing.Point(48, 89);
            rangoFechasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rangoFechasLabel.Name = "rangoFechasLabel";
            rangoFechasLabel.Size = new System.Drawing.Size(52, 16);
            rangoFechasLabel.TabIndex = 7;
            rangoFechasLabel.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(170, 89);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 16);
            label1.TabIndex = 9;
            label1.Text = "Hasta:";
            // 
            // fechaActualDateTimePicker
            // 
            this.fechaActualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActualDateTimePicker.Location = new System.Drawing.Point(1082, 109);
            this.fechaActualDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaActualDateTimePicker.Name = "fechaActualDateTimePicker";
            this.fechaActualDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.fechaActualDateTimePicker.TabIndex = 2;
            // 
            // movimientoReportadoTextBox
            // 
            this.movimientoReportadoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.movimientoReportadoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoReportadoTextBox.Location = new System.Drawing.Point(460, 109);
            this.movimientoReportadoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movimientoReportadoTextBox.Name = "movimientoReportadoTextBox";
            this.movimientoReportadoTextBox.ReadOnly = true;
            this.movimientoReportadoTextBox.Size = new System.Drawing.Size(99, 23);
            this.movimientoReportadoTextBox.TabIndex = 4;
            this.movimientoReportadoTextBox.Text = "Solo Entradas";
            // 
            // nombreProveedorComboBox
            // 
            this.nombreProveedorComboBox.FormattingEnabled = true;
            this.nombreProveedorComboBox.Location = new System.Drawing.Point(304, 107);
            this.nombreProveedorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreProveedorComboBox.Name = "nombreProveedorComboBox";
            this.nombreProveedorComboBox.Size = new System.Drawing.Size(133, 25);
            this.nombreProveedorComboBox.TabIndex = 6;
            // 
            // rangoFechasDateTimePicker
            // 
            this.rangoFechasDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangoFechasDateTimePicker.Location = new System.Drawing.Point(51, 109);
            this.rangoFechasDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.rangoFechasDateTimePicker.Name = "rangoFechasDateTimePicker";
            this.rangoFechasDateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.rangoFechasDateTimePicker.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 109);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(479, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "LISTA DE ENTRADAS";
            // 
            // CkOcultarPrecios
            // 
            this.CkOcultarPrecios.AutoSize = true;
            this.CkOcultarPrecios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkOcultarPrecios.Location = new System.Drawing.Point(1054, 143);
            this.CkOcultarPrecios.Name = "CkOcultarPrecios";
            this.CkOcultarPrecios.Size = new System.Drawing.Size(124, 20);
            this.CkOcultarPrecios.TabIndex = 51;
            this.CkOcultarPrecios.Text = "Ocultar Precios";
            this.CkOcultarPrecios.UseVisualStyleBackColor = true;
            this.CkOcultarPrecios.CheckedChanged += new System.EventHandler(this.CkOcultarPrecios_CheckedChanged);
            // 
            // reporteDetalladoEntradas_EncabezadoBindingSource
            // 
            this.reporteDetalladoEntradas_EncabezadoBindingSource.DataSource = typeof(BL.Bodega.ReporteDetalladoEntradas.Encabezado);
            // 
            // reporteDetalladoEntradas_InfoDataGridBindingSource
            // 
            this.reporteDetalladoEntradas_InfoDataGridBindingSource.DataSource = typeof(BL.Bodega.ReporteDetalladoEntradas.InfoDataGrid);
            // 
            // reporteDetalladoEntradas_InfoDataGridDataGridView
            // 
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.AutoGenerateColumns = false;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.DataSource = this.reporteDetalladoEntradas_InfoDataGridBindingSource;
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Location = new System.Drawing.Point(51, 169);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Name = "reporteDetalladoEntradas_InfoDataGridDataGridView";
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.Size = new System.Drawing.Size(1127, 315);
            this.reporteDetalladoEntradas_InfoDataGridDataGridView.TabIndex = 51;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaRegistro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha de Registro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOrden";
            this.dataGridViewTextBoxColumn3.HeaderText = "N° de Orden";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Proveedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn7.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Bodega";
            this.dataGridViewTextBoxColumn8.HeaderText = "Bodega";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn12.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(1078, 525);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(131, 42);
            this.BtnRegresar.TabIndex = 113;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmReporteDetalladoEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 579);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.reporteDetalladoEntradas_InfoDataGridDataGridView);
            this.Controls.Add(this.CkOcultarPrecios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label1);
            this.Controls.Add(fechaActualLabel);
            this.Controls.Add(this.fechaActualDateTimePicker);
            this.Controls.Add(movimientoReportadoLabel);
            this.Controls.Add(this.movimientoReportadoTextBox);
            this.Controls.Add(nombreProveedorLabel);
            this.Controls.Add(this.nombreProveedorComboBox);
            this.Controls.Add(rangoFechasLabel);
            this.Controls.Add(this.rangoFechasDateTimePicker);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmReporteDetalladoEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detallado de Entradas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_EncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDetalladoEntradas_InfoDataGridDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaActualDateTimePicker;
        private System.Windows.Forms.TextBox movimientoReportadoTextBox;
        private System.Windows.Forms.ComboBox nombreProveedorComboBox;
        private System.Windows.Forms.DateTimePicker rangoFechasDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CkOcultarPrecios;
        private System.Windows.Forms.BindingSource reporteDetalladoEntradas_EncabezadoBindingSource;
        private System.Windows.Forms.BindingSource reporteDetalladoEntradas_InfoDataGridBindingSource;
        private System.Windows.Forms.DataGridView reporteDetalladoEntradas_InfoDataGridDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button BtnRegresar;
    }
}