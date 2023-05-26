
namespace MultiBodega_v1.Configuración
{
    partial class FrmContenedorConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContenedorConfig));
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRol = new System.Windows.Forms.Button();
            this.BtnConf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.BtnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegresar.Location = new System.Drawing.Point(426, 280);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(136, 39);
            this.BtnRegresar.TabIndex = 67;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MultiBodega_v1.Properties.Resources.logo_catelsa;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRol
            // 
            this.BtnRol.BackColor = System.Drawing.Color.Transparent;
            this.BtnRol.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRol.FlatAppearance.BorderSize = 0;
            this.BtnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRol.ForeColor = System.Drawing.Color.Navy;
            this.BtnRol.Image = ((System.Drawing.Image)(resources.GetObject("BtnRol.Image")));
            this.BtnRol.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRol.Location = new System.Drawing.Point(289, 107);
            this.BtnRol.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRol.Name = "BtnRol";
            this.BtnRol.Size = new System.Drawing.Size(172, 116);
            this.BtnRol.TabIndex = 70;
            this.BtnRol.Text = "Crear Rol de Usuario";
            this.BtnRol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRol.UseVisualStyleBackColor = false;
            this.BtnRol.Click += new System.EventHandler(this.BtnRol_Click);
            // 
            // BtnConf
            // 
            this.BtnConf.BackColor = System.Drawing.Color.Transparent;
            this.BtnConf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnConf.FlatAppearance.BorderSize = 0;
            this.BtnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConf.ForeColor = System.Drawing.Color.Navy;
            this.BtnConf.Image = ((System.Drawing.Image)(resources.GetObject("BtnConf.Image")));
            this.BtnConf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConf.Location = new System.Drawing.Point(145, 107);
            this.BtnConf.Margin = new System.Windows.Forms.Padding(5);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(141, 116);
            this.BtnConf.TabIndex = 69;
            this.BtnConf.Text = "Configuración";
            this.BtnConf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnConf.UseVisualStyleBackColor = false;
            this.BtnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // FrmContenedorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(574, 331);
            this.Controls.Add(this.BtnRol);
            this.Controls.Add(this.BtnConf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegresar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContenedorConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRol;
        private System.Windows.Forms.Button BtnConf;
    }
}