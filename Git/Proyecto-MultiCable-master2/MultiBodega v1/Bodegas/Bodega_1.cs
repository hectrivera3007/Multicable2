using MultiBodega_v1.Botonera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Bodega
{
    public partial class Bodega_1 : Form
    {
        public Bodega_1()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBodegaBotonera Volver = new FrmBodegaBotonera();
            Volver.Show();
        }
    }
}
