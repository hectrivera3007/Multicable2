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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmContCompras();
            Volver.Show();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this._CATELSA_MULTICABLE.Compras);

        }
    }
}
