using MultiBodega_v1.Botonera;
using MultiBodega_v1.Formularios_de_Registro;
using MultiBodega_v1.Listar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Registro
{
    public partial class FrmRegistrar : Form
    {
        public string cUsuario;
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Botonera_APP Volver = new Botonera_APP(cUsuario);
            Volver.Show();
            this.Close();
        }

        private void BtnRP_Click(object sender, EventArgs e)
        {
            var nuevoproveedor = new FrmRegistrarProveedores();
            nuevoproveedor.Show();
            this.Close();
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            var nuevotec = new FrmRegistrarTecnico();
            nuevotec.Show();
            this.Close();
        }

        private void BtnRBF_Click(object sender, EventArgs e)
        {
            var nuevoBasef = new FrmRegistrarBaseForanea();
            nuevoBasef.Show();
            this.Close();
        }

        private void BtnRPV_Click(object sender, EventArgs e)
        {
            var nuevoPV = new FrmRegistrarPuntodeVenta();
            nuevoPV.Show();
            this.Close();
        }
    }
}
