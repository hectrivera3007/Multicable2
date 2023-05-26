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
            this.Close();
            FrmCompras Nuevo = new FrmCompras();
            Nuevo.Show();
        }

        private void BtnCostosImp_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCostosImport nuevoCost = new FrmCostosImport();
            nuevoCost.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrecioVenta nuevoPV = new FrmPrecioVenta();
            nuevoPV.Show();
        }
    }
}
