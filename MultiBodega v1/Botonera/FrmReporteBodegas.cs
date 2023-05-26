using MultiBodega_v1.Bodegas;
using MultiBodega_v1.Reporte_Bodegas;
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
    public partial class FrmReporteBodegas : Form
    {
        public FrmReporteBodegas()
        {
            InitializeComponent();
        }

        private void Bodega1_Click(object sender, EventArgs e)
        {
            var Bodega1_Inv = new Bodega1();
            Bodega1_Inv.Show();
        }

        private void Bodega2_Click(object sender, EventArgs e)
        {
            var Bodega2_Inv = new Bodega2();
            Bodega2_Inv.Show();
        }

        private void Bodega3_Click(object sender, EventArgs e)
        {
            var Bodega3_Inv = new Bodega3();
            Bodega3_Inv.Show();
        }

        private void Bodega4_Click(object sender, EventArgs e)
        {
            var Bodega4_Inv = new Bodega4();
            Bodega4_Inv.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
