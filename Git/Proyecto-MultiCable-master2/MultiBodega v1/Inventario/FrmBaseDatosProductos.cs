using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Inventario
{
    public partial class FrmBaseDatosProductos : Form
    {
        public FrmBaseDatosProductos()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void FrmBaseDatosProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Producto);
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            

        }
    }
}
