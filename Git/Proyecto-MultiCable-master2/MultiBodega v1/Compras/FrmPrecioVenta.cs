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
    public partial class FrmPrecioVenta : Form
    {
        int lastTabIndex;
        public FrmPrecioVenta()
        {
            InitializeComponent();

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContCompras Volver = new FrmContCompras();
            Volver.Show();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            costo_Total_Unitario_LPSTextBox.Text = "";
            costo_Total_Unitario_DolaresTextBox.Text = "";
            precioVentaLempirasTextBox.Text = "";
            precioVentaDolaresTextBox.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando variables
            decimal costo = decimal.Parse(costo_Total_Unitario_LPSTextBox.Text);
            decimal margen = decimal.Parse(margen_UtilidadTextBox.Text.ToString().Replace("%", ""));
            //Haciendo el calculo del resultado
            decimal precioVenta = costo * (1 + margen / 100);
            //Mostrando el resultado
            precioVentaLempirasTextBox.Text = precioVenta.ToString("F2");
            
        }

        private void BtnPdescuentoL_Click(object sender, EventArgs e)
        {
            //Declarando variables
            decimal precioVenta = decimal.Parse(precioVentaLempirasTextBox.Text);
            const decimal descuento1 = 10.0M;
            const decimal descuento2 = 15.0M;
            const decimal descuento3 = 20.0M;
            //const decimal descuento4 = 40.0M;
            //Haciendo los calculos de precios con descuento
            decimal precioDescuento1 = precioVenta - (precioVenta * descuento1 / 100);
            decimal precioDescuento2 = precioVenta - (precioVenta * descuento2 / 100);
            decimal precioDescuento3 = precioVenta - (precioVenta * descuento3 / 100);
            //decimal precioDescuento4 = precioVenta - (precioVenta * descuento4 / 100);
            //Mostrando los resultados
            P1LPS.Text = precioDescuento1.ToString("F2");
            P2LPS.Text = precioDescuento2.ToString("F2");
            P3LPS.Text = precioDescuento3.ToString("F2");
            //P4LPS.Text = precioDescuento4.ToString("F2");
        }

        private void BtnPdescuentoD_Click(object sender, EventArgs e)
        {
            //Declarando variables
            decimal precioVenta = decimal.Parse(precioVentaDolaresTextBox.Text);
            const decimal descuento1 = 10.0M;
            const decimal descuento2 = 15.0M;
            const decimal descuento3 = 20.0M;
            //const decimal descuento4 = 40.0M;
            //Haciendo los calculos de precios con descuento
            decimal precioDescuento1 = precioVenta - (precioVenta * descuento1 / 100);
            decimal precioDescuento2 = precioVenta - (precioVenta * descuento2 / 100);
            decimal precioDescuento3 = precioVenta - (precioVenta * descuento3 / 100);
            //decimal precioDescuento4 = precioVenta - (precioVenta * descuento4 / 100);
            //Mostrando los resultados de precio preferencial
            P1DOLAR.Text = precioDescuento1.ToString("F2");
            P2DOLAR.Text = precioDescuento2.ToString("F2");
            P3DOLAR.Text = precioDescuento3.ToString("F2");
            //P4DOLAR.Text = precioDescuento4.ToString("F2");
        }

        private void BtnPD_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            decimal costo = decimal.Parse(costo_Total_Unitario_DolaresTextBox.Text);
            decimal margen = decimal.Parse(margen_UtilidadTextBox.Text.ToString().Replace("%", ""));
            //Realizando la operación
            decimal precioVenta = costo * (1 + margen / 100);
            //Presentando resultados de la operación
            precioVentaDolaresTextBox.Text = precioVenta.ToString("F2");
        }
    }
}
