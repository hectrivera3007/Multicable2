using MultiBodega_v1.Botonera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Configuración
{
    public partial class FrmContenedorConfig : Form
    {
        public FrmContenedorConfig()
        {
            InitializeComponent();
        }

        private void BtnConf_Click(object sender, EventArgs e)
        {
            this.Close();
            var NuevoConf = new FrmConfig();
            NuevoConf.Show();
        }

        private void BtnRol_Click(object sender, EventArgs e)
        {
            this.Close();
            var NuevoRol = new FrmRol();
            NuevoRol.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new Botonera_APP();
            Volver.Show();
        }
    }
}
