
namespace MultiBodega_v1.Compras
{
    partial class CambioDolar
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFactorCambiario = new System.Windows.Forms.Button();
            this.LblFC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBTENER CAMBIO DEL DOLAR";
            // 
            // BtnFactorCambiario
            // 
            this.BtnFactorCambiario.BackColor = System.Drawing.Color.Transparent;
            this.BtnFactorCambiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFactorCambiario.FlatAppearance.BorderSize = 0;
            this.BtnFactorCambiario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFactorCambiario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFactorCambiario.Image = global::MultiBodega_v1.Properties.Resources.stock_exchange;
            this.BtnFactorCambiario.Location = new System.Drawing.Point(276, 82);
            this.BtnFactorCambiario.Name = "BtnFactorCambiario";
            this.BtnFactorCambiario.Size = new System.Drawing.Size(90, 74);
            this.BtnFactorCambiario.TabIndex = 1;
            this.BtnFactorCambiario.Text = "Consultar";
            this.BtnFactorCambiario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFactorCambiario.UseVisualStyleBackColor = false;
            //this.BtnFactorCambiario.Click += new System.EventHandler(this.BtnFactorCambiario_Click);
            // 
            // LblFC
            // 
            this.LblFC.AutoSize = true;
            this.LblFC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblFC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LblFC.Location = new System.Drawing.Point(53, 176);
            this.LblFC.Name = "LblFC";
            this.LblFC.Size = new System.Drawing.Size(32, 17);
            this.LblFC.TabIndex = 3;
            this.LblFC.Text = "123";
            // 
            // CambioDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(390, 229);
            this.Controls.Add(this.LblFC);
            this.Controls.Add(this.BtnFactorCambiario);
            this.Controls.Add(this.label1);
            this.Name = "CambioDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio delDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFactorCambiario;
        private System.Windows.Forms.Label LblFC;
    }
}