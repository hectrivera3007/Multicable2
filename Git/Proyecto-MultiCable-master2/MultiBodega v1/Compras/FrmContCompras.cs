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

namespace MultiBodega_v1.Compras
{
    public partial class FrmContCompras : Form
    {
        public FrmContCompras()
        {
            InitializeComponent();
        }

        private void BtnAgUsuario_Click(object sender, EventArgs e)
        {
            FrmCompras Nuevo = new FrmCompras();
            Nuevo.Show();
            this.Close();
        }

        private void BtnCostosImp_Click(object sender, EventArgs e)
        {
            FrmCostosImport nuevoCost = new FrmCostosImport();
            nuevoCost.Show();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            FrmPrecioVenta nuevoPV = new FrmPrecioVenta();
            nuevoPV.Show();
            this.Close();
        }
    }
}
