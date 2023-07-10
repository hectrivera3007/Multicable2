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
        public string cUsuario;
        public FrmContenedorConfig()
        {
            InitializeComponent();
        }

        private void BtnConf_Click(object sender, EventArgs e)
        {
            var NuevoConf = new FrmConfig();
            NuevoConf.Show();
            this.Close();
        }

        private void BtnRol_Click(object sender, EventArgs e)
        {
            var NuevoRol = new FrmRol();
            NuevoRol.Show();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            var Volver = new Botonera_APP(cUsuario);
            Volver.Show();
            this.Close();
        }
    }
}
