
namespace MultiBodega_v1.Inventario
{
    partial class ModificarProducto
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
            System.Windows.Forms.Label bodegaIDLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label codigoProdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.DtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.bodegaIDComboBox = new System.Windows.Forms.ComboBox();
            this.iDProducto = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigoGen = new System.Windows.Forms.TextBox();
            this.CmbNombreTipo = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            bodegaIDLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            codigoProdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtFechaIngreso
            // 
            this.DtFechaIngreso.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaIngreso.CustomFormat = "";
            this.DtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFechaIngreso.Location = new System.Drawing.Point(245, 210);
            this.DtFechaIngreso.Name = "DtFechaIngreso";
            this.DtFechaIngreso.Size = new System.Drawing.Size(194, 20);
            this.DtFechaIngreso.TabIndex = 71;
            this.DtFechaIngreso.Value = new System.DateTime(2023, 6, 22, 15, 15, 58, 0);
            // 
            // bodegaIDLabel
            // 
            bodegaIDLabel.AutoSize = true;
            bodegaIDLabel.BackColor = System.Drawing.Color.Transparent;
            bodegaIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bodegaIDLabel.Location = new System.Drawing.Point(245, 245);
            bodegaIDLabel.Name = "bodegaIDLabel";
            bodegaIDLabel.Size = new System.Drawing.Size(63, 16);
            bodegaIDLabel.TabIndex = 80;
            bodegaIDLabel.Text = "Bodega:";
            // 
            // bodegaIDComboBox
            // 
            this.bodegaIDComboBox.FormattingEnabled = true;
            this.bodegaIDComboBox.Location = new System.Drawing.Point(245, 265);
            this.bodegaIDComboBox.Name = "bodegaIDComboBox";
            this.bodegaIDComboBox.Size = new System.Drawing.Size(194, 21);
            this.bodegaIDComboBox.TabIndex = 73;
            this.bodegaIDComboBox.ValueMember = "BodegaID";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.BackColor = System.Drawing.Color.Transparent;
            iDProductoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDProductoLabel.Location = new System.Drawing.Point(31, 145);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(25, 16);
            iDProductoLabel.TabIndex = 79;
            iDProductoLabel.Text = "ID:";
            // 
            // iDProducto
            // 
            this.iDProducto.Location = new System.Drawing.Point(31, 165);
            this.iDProducto.Name = "iDProducto";
            this.iDProducto.ReadOnly = true;
            this.iDProducto.Size = new System.Drawing.Size(76, 20);
            this.iDProducto.TabIndex = 81;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.activoCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(31, 293);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(68, 24);
            this.activoCheckBox.TabIndex = 74;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = false;
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.BackColor = System.Drawing.Color.Transparent;
            fechaIngresoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaIngresoLabel.Location = new System.Drawing.Point(245, 190);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(103, 16);
            fechaIngresoLabel.TabIndex = 77;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "-";
            // 
            // TxtCodigoGen
            // 
            this.TxtCodigoGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoGen.Location = new System.Drawing.Point(127, 210);
            this.TxtCodigoGen.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigoGen.Name = "TxtCodigoGen";
            this.TxtCodigoGen.Size = new System.Drawing.Size(98, 20);
            this.TxtCodigoGen.TabIndex = 70;
            // 
            // CmbNombreTipo
            // 
            this.CmbNombreTipo.FormattingEnabled = true;
            this.CmbNombreTipo.Items.AddRange(new object[] {
            "MPI",
            "MPN",
            "MPC",
            "MPF"});
            this.CmbNombreTipo.Location = new System.Drawing.Point(31, 210);
            this.CmbNombreTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNombreTipo.Name = "CmbNombreTipo";
            this.CmbNombreTipo.Size = new System.Drawing.Size(76, 21);
            this.CmbNombreTipo.TabIndex = 69;
            // 
            // codigoProdLabel
            // 
            codigoProdLabel.AutoSize = true;
            codigoProdLabel.BackColor = System.Drawing.Color.Transparent;
            codigoProdLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoProdLabel.Location = new System.Drawing.Point(31, 190);
            codigoProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoProdLabel.Name = "codigoProdLabel";
            codigoProdLabel.Size = new System.Drawing.Size(121, 16);
            codigoProdLabel.TabIndex = 75;
            codigoProdLabel.Text = "Código Producto:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(31, 263);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(194, 23);
            this.TxtDescripcion.TabIndex = 72;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(31, 243);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(89, 16);
            descripcionLabel.TabIndex = 76;
            descripcionLabel.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(71, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = " MODIFICAR PRODUCTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::MultiBodega_v1.Properties.Resources.actualizar1;
            this.BtnGuardar.Location = new System.Drawing.Point(384, 294);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(55, 45);
            this.BtnGuardar.TabIndex = 85;
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtFechaIngreso);
            this.Controls.Add(bodegaIDLabel);
            this.Controls.Add(this.bodegaIDComboBox);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProducto);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCodigoGen);
            this.Controls.Add(this.CmbNombreTipo);
            this.Controls.Add(codigoProdLabel);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(descripcionLabel);
            this.Name = "ModificarProducto";
            this.Text = "Modificar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtFechaIngreso;
        private System.Windows.Forms.ComboBox bodegaIDComboBox;
        private System.Windows.Forms.TextBox iDProducto;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigoGen;
        private System.Windows.Forms.ComboBox CmbNombreTipo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnGuardar;
    }
}