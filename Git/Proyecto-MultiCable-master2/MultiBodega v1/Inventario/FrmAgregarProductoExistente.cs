using MultiBodega_v1.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1
{
    public partial class FrmAgregarProductoExistente : Form
    {
        public FrmAgregarProductoExistente()
        {
            InitializeComponent();
        }
        private void FrmAgregarProductoExistente_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var buscarprod = new FrmBaseDatosProductos();
            buscarprod.MdiParent = this;
            buscarprod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
