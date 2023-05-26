using MultiBodega_v1.Formularios_de_Registro;
using MultiBodega_v1.Inventario;
using MultiBodega_v1.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Listar
{
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void BtnLP_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListarProveedor nuevoprov = new FrmListarProveedor();
            nuevoprov.Show();
        }

        private void BtnLT_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListarTecnicos nuevotec = new FrmListarTecnicos();
            nuevotec.Show();
        }

        private void BtnLF_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListarBaseForanea nuevobf = new FrmListarBaseForanea();
            nuevobf.Show();
        }

        private void BtnLPV_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListarPuntodeVenta nuevopv = new FrmListarPuntodeVenta();
            nuevopv.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar VolverAtras = new FrmRegistrar();
            VolverAtras.Show();
        }
    }
}
