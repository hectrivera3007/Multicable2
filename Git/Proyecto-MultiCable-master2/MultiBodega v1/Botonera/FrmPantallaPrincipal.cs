using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Botonera
{
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            var Botonera = new LoginBodega();
            Botonera.ShowDialog();
            BtnEntrar.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
