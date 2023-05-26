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
            this.Close();
            Botonera_APP nuevo = new Botonera_APP();
            nuevo.Show();
        }

        private void BtnRegEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
            var RequisaEntrada = new FrmRequisaEntrada();
            RequisaEntrada.Show();
        }

        private void BtnRegSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            var RequisaSalida = new FrmRequisaSalida();
            RequisaSalida.Show();
        }

        private void BtnBuscEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
            var BuscarEntrada= new FrmBuscarEntrada();
            BuscarEntrada.Show();
        }

        private void BtnBuscSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            var BuscarSalida = new FrmBuscarSalida();
            BuscarSalida.Show();
        }

        private void BtnComprEntrada_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmComprobanteEntrega Nuevo = new FrmComprobanteEntrega();
            Nuevo.Show();
        }
    }
}
