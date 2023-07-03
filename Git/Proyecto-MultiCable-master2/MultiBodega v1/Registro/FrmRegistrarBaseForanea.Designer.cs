
namespace MultiBodega_v1.Formularios_de_Registro
{
    partial class FrmRegistrarBaseForanea
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
            System.Windows.Forms.Label num_TelefonoLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label lugar_ZonaLabel;
            System.Windows.Forms.Label fechaRegistroLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarBaseForanea));
            this.registro_RegistrarBaseForaneaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.num_TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.lugar_ZonaTextBox = new System.Windows.Forms.TextBox();
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nuevoTextBox = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            num_TelefonoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            lugar_ZonaLabel = new System.Windows.Forms.Label();
            fechaRegistroLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarBaseForaneaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registro_RegistrarBaseForaneaBindingSource
            // 
            this.registro_RegistrarBaseForaneaBindingSource.DataSource = typeof(BL.Bodega.Registrar.Registro.RegistrarBaseForanea);
            // 
            // num_TelefonoTextBox
            // 
            this.num_TelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_RegistrarBaseForaneaBindingSource, "Num_Telefono", true));
            this.num_TelefonoTextBox.Location = new System.Drawing.Point(59, 279);
            this.num_TelefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_TelefonoTextBox.Name = "num_TelefonoTextBox";
            this.num_TelefonoTextBox.Size = new System.Drawing.Size(265, 23);
            this.num_TelefonoTextBox.TabIndex = 3;
            // 
            // num_TelefonoLabel
            // 
            num_TelefonoLabel.AutoSize = true;
            num_TelefonoLabel.BackColor = System.Drawing.Color.Transparent;
            num_TelefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_TelefonoLabel.Location = new System.Drawing.Point(56, 260);
            num_TelefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            num_TelefonoLabel.Name = "num_TelefonoLabel";
            num_TelefonoLabel.Size = new System.Drawing.Size(142, 16);
            num_TelefonoLabel.TabIndex = 12;
            num_TelefonoLabel.Text = "Número de Teléfono:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_RegistrarBaseForaneaBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(59, 323);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(553, 88);
            this.notasTextBox.TabIndex = 5;
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.BackColor = System.Drawing.Color.Transparent;
            notasLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notasLabel.Location = new System.Drawing.Point(56, 304);
            notasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 16);
            notasLabel.TabIndex = 10;
            notasLabel.Text = "Notas:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_RegistrarBaseForaneaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(59, 161);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(371, 23);
            this.nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(56, 142);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 16);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // lugar_ZonaTextBox
            // 
            this.lugar_ZonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_RegistrarBaseForaneaBindingSource, "Lugar_Zona", true));
            this.lugar_ZonaTextBox.Location = new System.Drawing.Point(347, 279);
            this.lugar_ZonaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lugar_ZonaTextBox.Name = "lugar_ZonaTextBox";
            this.lugar_ZonaTextBox.Size = new System.Drawing.Size(265, 23);
            this.lugar_ZonaTextBox.TabIndex = 4;
            // 
            // lugar_ZonaLabel
            // 
            lugar_ZonaLabel.AutoSize = true;
            lugar_ZonaLabel.BackColor = System.Drawing.Color.Transparent;
            lugar_ZonaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lugar_ZonaLabel.Location = new System.Drawing.Point(344, 260);
            lugar_ZonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lugar_ZonaLabel.Name = "lugar_ZonaLabel";
            lugar_ZonaLabel.Size = new System.Drawing.Size(87, 16);
            lugar_ZonaLabel.TabIndex = 6;
            lugar_ZonaLabel.Text = "Lugar/Zona:";
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registro_RegistrarBaseForaneaBindingSource, "FechaRegistro", true));
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(502, 160);
            this.FechaRegistroDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.FechaRegistroDateTimePicker.TabIndex = 1;
            // 
            // fechaRegistroLabel
            // 
            fechaRegistroLabel.AutoSize = true;
            fechaRegistroLabel.BackColor = System.Drawing.Color.Transparent;
            fechaRegistroLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaRegistroLabel.Location = new System.Drawing.Point(499, 142);
            fechaRegistroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaRegistroLabel.Name = "fechaRegistroLabel";
            fechaRegistroLabel.Size = new System.Drawing.Size(107, 16);
            fechaRegistroLabel.TabIndex = 2;
            fechaRegistroLabel.Text = "Fecha Registro:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_RegistrarBaseForaneaBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(59, 205);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(553, 53);
            this.direccionTextBox.TabIndex = 2;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(56, 186);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(74, 16);
            direccionLabel.TabIndex = 0;
            direccionLabel.Text = "Direccion:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(652, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Modificar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(652, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(652, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "&Eliminar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // nuevoTextBox
            // 
            this.nuevoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.BorderSize = 0;
            this.nuevoTextBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nuevoTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nuevoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoTextBox.Image = ((System.Drawing.Image)(resources.GetObject("nuevoTextBox.Image")));
            this.nuevoTextBox.Location = new System.Drawing.Point(652, 247);
            this.nuevoTextBox.Name = "nuevoTextBox";
            this.nuevoTextBox.Size = new System.Drawing.Size(105, 28);
            this.nuevoTextBox.TabIndex = 6;
            this.nuevoTextBox.Text = "&Nuevo";
            this.nuevoTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoTextBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.nuevoTextBox.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(212, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 32);
            this.label2.TabIndex = 72;
            this.label2.Text = "REGISTRAR BASE FORÁNEA";
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
            this.BtnRegresar.Location = new System.Drawing.Point(633, 446);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 73;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // FrmRegistrarBaseForanea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources._Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 492);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nuevoTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(fechaRegistroLabel);
            this.Controls.Add(this.FechaRegistroDateTimePicker);
            this.Controls.Add(lugar_ZonaLabel);
            this.Controls.Add(this.lugar_ZonaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(num_TelefonoLabel);
            this.Controls.Add(this.num_TelefonoTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarBaseForanea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Base Foranea";
            ((System.ComponentModel.ISupportInitialize)(this.registro_RegistrarBaseForaneaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource registro_RegistrarBaseForaneaBindingSource;
        private System.Windows.Forms.TextBox num_TelefonoTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox lugar_ZonaTextBox;
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button nuevoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegresar;
    }
}