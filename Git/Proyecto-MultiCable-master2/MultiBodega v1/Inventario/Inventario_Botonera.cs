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

namespace MultiBodega_v1.Botonera
{
    public partial class Inventario_Botonera : Form
    {
        public Inventario_Botonera()
        {
            InitializeComponent();
        }
        
        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            var producto = new FrmIngresarProducto();
            producto.ShowDialog(this);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Estás seguro de volver a la vista principal?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                this.Close();
                Botonera_APP nuevo = new Botonera_APP();
                nuevo.ShowDialog();
            }
        }

        private void BtnModificarProd_Click(object sender, EventArgs e)
        {
            var modificar_producto = new FrmIngresarProducto();
            modificar_producto.ShowDialog(this);

        }

        private void BtnInventarioFinal_Click(object sender, EventArgs e)
        {
            var muestra_inventario = new FrmInventarioGeneral();
            muestra_inventario.ShowDialog(this);

        }

        private void BtnAjusteInventario_Click(object sender, EventArgs e)
        {
            var ajuste_inventario = new AjusteInventario();
            ajuste_inventario.ShowDialog(this);
        }

        private void BtnInventXbodega_Click(object sender, EventArgs e)
        {
            var ReporteBodega = new FrmReporteBodegas();
            ReporteBodega.ShowDialog(this);
        }

        
    }
}
