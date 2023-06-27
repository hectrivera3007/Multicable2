using MultiBodega_v1.Botonera;
using MultiBodega_v1.Inventario;
using MultiBodega_v1.Listar;
using MultiBodega_v1.Reporte_Bodegas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Reportes
{
    public partial class FrmContReportes : Form
    {
        public FrmContReportes()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
            this.Close();
        }

        private void BtnReportesBodegas_Click(object sender, EventArgs e)
        {
            var ReporteBodegas = new FrmReporteBodegas();
            ReporteBodegas.Show();
            this.Close();
        }

        private void BtnStockMinimo_Click(object sender, EventArgs e)
        {
            var BajosMinimos= new FrmBajosMinimos();
            BajosMinimos.Show();
            this.Close();
        }

        private void BtnReporteEntradas_Click(object sender, EventArgs e)
        {
            var ReporteDetalladoEntradas = new FrmReporteDetalladoEntradas();
            ReporteDetalladoEntradas.Show();
            this.Close();
        }

        private void BtnReporteSalidas_Click(object sender, EventArgs e)
        {
            var ReporteDetalladoSalidas = new FrmReporteDetalladoSalidas();
            ReporteDetalladoSalidas.Show();
            this.Close();
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            var Devoluciones = new FrmDevoluciones();
            Devoluciones.Show();
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            var Listar = new FrmListar();
            Listar.Show();
            this.Close();
        }
    }
}
