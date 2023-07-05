
namespace MultiBodega_v1.Inventario
{
    partial class FrmDevoluciones
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
            System.Windows.Forms.Label num_OrdenLabel;
            System.Windows.Forms.Label numero_ReferenciaLabel;
            System.Windows.Forms.Label devuelto_porLabel;
            System.Windows.Forms.Label notasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevoluciones));
            this.devoluciones_DevolucionesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.num_OrdenComboBox = new System.Windows.Forms.ComboBox();
            this.numero_ReferenciaComboBox = new System.Windows.Forms.ComboBox();
            this.devoluciones_DevolucionesDataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devoluciones_DevolucionesDataGridDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devueltoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devuelto_porComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nuevoTextBox = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            fechaLabel = new System.Windows.Forms.Label();
            num_OrdenLabel = new System.Windows.Forms.Label();
            numero_ReferenciaLabel = new System.Windows.Forms.Label();
            devuelto_porLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesDataGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesDataGridDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.Transparent;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(49, 88);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 16);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // num_OrdenLabel
            // 
            num_OrdenLabel.AutoSize = true;
            num_OrdenLabel.BackColor = System.Drawing.Color.Transparent;
            num_OrdenLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_OrdenLabel.Location = new System.Drawing.Point(152, 88);
            num_OrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_OrdenLabel.Name = "num_OrdenLabel";
            num_OrdenLabel.Size = new System.Drawing.Size(129, 16);
            num_OrdenLabel.TabIndex = 9;
            num_OrdenLabel.Text = "Número de Orden:";
            // 
            // numero_ReferenciaLabel
            // 
            numero_ReferenciaLabel.AutoSize = true;
            numero_ReferenciaLabel.BackColor = System.Drawing.Color.Transparent;
            numero_ReferenciaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_ReferenciaLabel.Location = new System.Drawing.Point(49, 148);
            numero_ReferenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_ReferenciaLabel.Name = "numero_ReferenciaLabel";
            numero_ReferenciaLabel.Size = new System.Drawing.Size(137, 16);
            numero_ReferenciaLabel.TabIndex = 11;
            numero_ReferenciaLabel.Text = "Número Referencia:";
            // 
            // devuelto_porLabel
            // 
            devuelto_porLabel.AutoSize = true;
            devuelto_porLabel.BackColor = System.Drawing.Color.Transparent;
            devuelto_porLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            devuelto_porLabel.Location = new System.Drawing.Point(345, 88);
            devuelto_porLabel.Name = "devuelto_porLabel";
            devuelto_porLabel.Size = new System.Drawing.Size(94, 16);
            devuelto_porLabel.TabIndex = 12;
            devuelto_porLabel.Text = "Devuelto por:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(46, 409);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 61;
            notasLabel.Text = "Notas:";
            // 
            // devoluciones_DevolucionesInfoBindingSource
            // 
            this.devoluciones_DevolucionesInfoBindingSource.DataSource = typeof(BL.Bodega.Devoluciones.DevolucionesInfo);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.devoluciones_DevolucionesInfoBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(52, 108);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(92, 23);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // num_OrdenComboBox
            // 
            this.num_OrdenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devoluciones_DevolucionesInfoBindingSource, "Num_Orden", true));
            this.num_OrdenComboBox.FormattingEnabled = true;
            this.num_OrdenComboBox.Location = new System.Drawing.Point(155, 110);
            this.num_OrdenComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_OrdenComboBox.Name = "num_OrdenComboBox";
            this.num_OrdenComboBox.Size = new System.Drawing.Size(168, 25);
            this.num_OrdenComboBox.TabIndex = 10;
            // 
            // numero_ReferenciaComboBox
            // 
            this.numero_ReferenciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devoluciones_DevolucionesInfoBindingSource, "Numero_Referencia", true));
            this.numero_ReferenciaComboBox.FormattingEnabled = true;
            this.numero_ReferenciaComboBox.Location = new System.Drawing.Point(190, 143);
            this.numero_ReferenciaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.numero_ReferenciaComboBox.Name = "numero_ReferenciaComboBox";
            this.numero_ReferenciaComboBox.Size = new System.Drawing.Size(151, 25);
            this.numero_ReferenciaComboBox.TabIndex = 12;
            // 
            // devoluciones_DevolucionesDataGridBindingSource
            // 
            this.devoluciones_DevolucionesDataGridBindingSource.DataSource = typeof(BL.Bodega.Devoluciones.DevolucionesDataGrid);
            // 
            // devoluciones_DevolucionesDataGridDataGridView
            // 
            this.devoluciones_DevolucionesDataGridDataGridView.AutoGenerateColumns = false;
            this.devoluciones_DevolucionesDataGridDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.devoluciones_DevolucionesDataGridDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devoluciones_DevolucionesDataGridDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.entregadoDataGridViewTextBoxColumn,
            this.devueltoDataGridViewTextBoxColumn});
            this.devoluciones_DevolucionesDataGridDataGridView.DataSource = this.devoluciones_DevolucionesDataGridBindingSource;
            this.devoluciones_DevolucionesDataGridDataGridView.Location = new System.Drawing.Point(49, 177);
            this.devoluciones_DevolucionesDataGridDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.devoluciones_DevolucionesDataGridDataGridView.Name = "devoluciones_DevolucionesDataGridDataGridView";
            this.devoluciones_DevolucionesDataGridDataGridView.Size = new System.Drawing.Size(753, 226);
            this.devoluciones_DevolucionesDataGridDataGridView.TabIndex = 12;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 300;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            // 
            // entregadoDataGridViewTextBoxColumn
            // 
            this.entregadoDataGridViewTextBoxColumn.DataPropertyName = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.HeaderText = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.Name = "entregadoDataGridViewTextBoxColumn";
            // 
            // devueltoDataGridViewTextBoxColumn
            // 
            this.devueltoDataGridViewTextBoxColumn.DataPropertyName = "Devuelto";
            this.devueltoDataGridViewTextBoxColumn.HeaderText = "Devuelto";
            this.devueltoDataGridViewTextBoxColumn.Name = "devueltoDataGridViewTextBoxColumn";
            // 
            // devuelto_porComboBox
            // 
            this.devuelto_porComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devoluciones_DevolucionesInfoBindingSource, "Devuelto_por", true));
            this.devuelto_porComboBox.FormattingEnabled = true;
            this.devuelto_porComboBox.Location = new System.Drawing.Point(348, 110);
            this.devuelto_porComboBox.Name = "devuelto_porComboBox";
            this.devuelto_porComboBox.Size = new System.Drawing.Size(167, 25);
            this.devuelto_porComboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "DEVOLUCIONES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(348, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 25);
            this.button1.TabIndex = 48;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nuevoTextBox
            // 
            this.nuevoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nuevoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoTextBox.Image = ((System.Drawing.Image)(resources.GetObject("nuevoTextBox.Image")));
            this.nuevoTextBox.Location = new System.Drawing.Point(823, 364);
            this.nuevoTextBox.Name = "nuevoTextBox";
            this.nuevoTextBox.Size = new System.Drawing.Size(105, 28);
            this.nuevoTextBox.TabIndex = 60;
            this.nuevoTextBox.Text = "&Nuevo";
            this.nuevoTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoTextBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevoTextBox.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(823, 500);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 28);
            this.button5.TabIndex = 59;
            this.button5.Text = "&Salir";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(823, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 58;
            this.button4.Text = "&Eliminar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(823, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 56;
            this.button2.Text = "&Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(823, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 57;
            this.button3.Text = "&Modificar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.devoluciones_DevolucionesInfoBindingSource, "Notas", true));
            this.notasTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasTextBox.Location = new System.Drawing.Point(49, 431);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(753, 97);
            this.notasTextBox.TabIndex = 62;
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
            this.BtnRegresar.Location = new System.Drawing.Point(804, 566);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(131, 42);
            this.BtnRegresar.TabIndex = 113;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 620);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(this.nuevoTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(devuelto_porLabel);
            this.Controls.Add(this.devuelto_porComboBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(num_OrdenLabel);
            this.Controls.Add(this.num_OrdenComboBox);
            this.Controls.Add(numero_ReferenciaLabel);
            this.Controls.Add(this.numero_ReferenciaComboBox);
            this.Controls.Add(this.devoluciones_DevolucionesDataGridDataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Devolución";
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesDataGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devoluciones_DevolucionesDataGridDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource devoluciones_DevolucionesInfoBindingSource;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox num_OrdenComboBox;
        private System.Windows.Forms.ComboBox numero_ReferenciaComboBox;
        private System.Windows.Forms.BindingSource devoluciones_DevolucionesDataGridBindingSource;
        private System.Windows.Forms.DataGridView devoluciones_DevolucionesDataGridDataGridView;
        private System.Windows.Forms.ComboBox devuelto_porComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devueltoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nuevoTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.Button BtnRegresar;
    }
}