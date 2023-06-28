
namespace MultiBodega_v1.Botonera
{
    partial class FrmPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(160, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1047, 404);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.BtnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(177)))), ((int)(((byte)(29)))));
            this.BtnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntrar.Image")));
            this.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnEntrar.Location = new System.Drawing.Point(1191, 580);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(163, 71);
            this.BtnEntrar.TabIndex = 14;
            this.BtnEntrar.Text = "&Entrar";
            this.BtnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::MultiBodega_v1.Properties.Resources.Fondo_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 725);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnEntrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CATELSA LOGISTIC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}