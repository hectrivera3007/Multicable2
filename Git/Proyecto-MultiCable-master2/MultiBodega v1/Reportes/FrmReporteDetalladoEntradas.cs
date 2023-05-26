using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Reporte_Bodegas
{
    public partial class FrmReporteDetalladoEntradas : Form
    {
        public FrmReporteDetalladoEntradas()
        {
            InitializeComponent();
        }

        //INSTANCIAR OBJETO ERROR
        private void CkOcultarPrecios_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CkOcultarPrecios.Checked)
            {
                reporteDetalladoEntradas_InfoDataGridDataGridView.Columns["Precio de Compra"].Visible = false;
                reporteDetalladoEntradas_InfoDataGridDataGridView.Columns["Precio Venta"].Visible = false;
                reporteDetalladoEntradas_InfoDataGridDataGridView.Columns["SubTotal"].Visible = false;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
