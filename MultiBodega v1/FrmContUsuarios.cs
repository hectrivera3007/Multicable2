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

namespace MultiBodega_v1
{
    public partial class FrmContUsuarios : Form
    {
        public FrmContUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAgUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoUsuario nuevoU = new NuevoUsuario();
            nuevoU.Show();
        }

        private void BtnVUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUsuarios nuevoVer = new FrmUsuarios();
            nuevoVer.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_APP Volver = new Botonera_APP();
            Volver.Show();
        }
    }
}
