
namespace MultiBodega_v1.Requisas
{
    partial class FrmBuscarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarEntrada));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LblNOrden = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Requisa_RequisaEntradaDataGridView = new System.Windows.Forms.DataGridView();
            this.requisaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.requisa_RequisaEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Requisa_RequisaEntradaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisa_RequisaEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Orden";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(261, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 49;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 23);
            this.textBox1.TabIndex = 50;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(349, 148);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(82, 25);
            this.BtnLimpiar.TabIndex = 51;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LblNOrden
            // 
            this.LblNOrden.AutoSize = true;
            this.LblNOrden.BackColor = System.Drawing.Color.Transparent;
            this.LblNOrden.ForeColor = System.Drawing.Color.Black;
            this.LblNOrden.Location = new System.Drawing.Point(438, 152);
            this.LblNOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNOrden.Name = "LblNOrden";
            this.LblNOrden.Size = new System.Drawing.Size(76, 17);
            this.LblNOrden.TabIndex = 52;
            this.LblNOrden.Text = "LblNOrden";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 5);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(571, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 23);
            this.textBox3.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(568, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Documento Proveedor:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(762, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 23);
            this.textBox4.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(759, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Proveedor:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(762, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 23);
            this.textBox5.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(759, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(33, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 5);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // Requisa_RequisaEntradaDataGridView
            // 
            this.Requisa_RequisaEntradaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Requisa_RequisaEntradaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Requisa_RequisaEntradaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Requisa_RequisaEntradaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Requisa_RequisaEntradaDataGridView.ColumnHeadersHeight = 45;
            this.Requisa_RequisaEntradaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Requisa_RequisaEntradaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requisaIDDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn});
            this.Requisa_RequisaEntradaDataGridView.EnableHeadersVisualStyles = false;
            this.Requisa_RequisaEntradaDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.Requisa_RequisaEntradaDataGridView.Location = new System.Drawing.Point(33, 242);
            this.Requisa_RequisaEntradaDataGridView.Name = "Requisa_RequisaEntradaDataGridView";
            this.Requisa_RequisaEntradaDataGridView.Size = new System.Drawing.Size(959, 330);
            this.Requisa_RequisaEntradaDataGridView.TabIndex = 67;
            // 
            // requisaIDDataGridViewTextBoxColumn
            // 
            this.requisaIDDataGridViewTextBoxColumn.DataPropertyName = "RequisaID";
            this.requisaIDDataGridViewTextBoxColumn.HeaderText = "RequisaID";
            this.requisaIDDataGridViewTextBoxColumn.Name = "requisaIDDataGridViewTextBoxColumn";
            this.requisaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 405;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RequisaID";
            this.Column1.HeaderText = "Medida";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RequisaID";
            this.Column2.HeaderText = "Bodega";
            this.Column2.Name = "Column2";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "Precio Compra";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Venta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 588);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(99, 588);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "0.00";
            // 
            // requisa_RequisaEntradaBindingSource
            // 
            this.requisa_RequisaEntradaBindingSource.DataSource = typeof(BL.Bodega.Requisa.RequisaEntrada);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(388, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 32);
            this.label8.TabIndex = 84;
            this.label8.Text = "BUSCAR ENTRADA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
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
            this.BtnRegresar.Location = new System.Drawing.Point(876, 592);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 85;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 23);
            this.dateTimePicker1.TabIndex = 87;
            // 
            // FrmBuscarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Requisa_RequisaEntradaDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblNOrden);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.Requisa_RequisaEntradaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisa_RequisaEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LblNOrden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Requisa_RequisaEntradaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource requisa_RequisaEntradaBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}