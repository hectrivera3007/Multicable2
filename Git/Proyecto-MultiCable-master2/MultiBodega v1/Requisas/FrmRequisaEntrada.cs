using MultiBodega_v1.Botonera.Requisas;
using MultiBodega_v1.Inventario;
using MultiBodega_v1.Properties;
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
    public partial class FrmRequisaEntrada : Form
    {
        public FrmRequisaEntrada()
        {
            InitializeComponent();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image img = Resources.Header;
            e.Graphics.DrawImage(img, 0, 0, img.Width, img.Width);
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var BuscarProd = new FrmBaseDatosProductos();
            BuscarProd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoTextBox_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var NuevaRequisa = new Botonera_Requisas();
            NuevaRequisa.Show();
        }

        private void FrmRequisaEntrada_Load(object sender, EventArgs e)
        {
            

        }
    }
}
