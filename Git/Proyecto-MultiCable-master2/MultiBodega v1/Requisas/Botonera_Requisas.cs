using MultiBodega_v1.Requisas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Botonera.Requisas
{
    public partial class Botonera_Requisas : Form
    {
        public Botonera_Requisas()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Botonera_APP nuevo = new Botonera_APP();
            nuevo.Show();
            this.Close();
        }

        private void BtnRegEntrada_Click(object sender, EventArgs e)
        {
            var RequisaEntrada = new FrmRequisaEntrada();
            RequisaEntrada.Show();
            this.Close();
        }

        private void BtnRegSalida_Click(object sender, EventArgs e)
        {
            var RequisaSalida = new FrmRequisaSalida();
            RequisaSalida.Show();
            this.Close();
        }

        private void BtnBuscEntrada_Click(object sender, EventArgs e)
        {
            var BuscarEntrada= new FrmBuscarEntrada();
            BuscarEntrada.Show();
            this.Close();
        }

        private void BtnBuscSalida_Click(object sender, EventArgs e)
        {
            var BuscarSalida = new FrmBuscarSalida();
            BuscarSalida.Show();
            this.Close();
        }

        private void BtnComprEntrada_Click(object sender, EventArgs e)
        {
            FrmComprobanteEntrega Nuevo = new FrmComprobanteEntrega();
            Nuevo.Show();
            this.Close();
        }
    }
}
