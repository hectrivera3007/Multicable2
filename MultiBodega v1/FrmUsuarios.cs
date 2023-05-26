using BL.Bodega;
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
    public partial class FrmUsuarios : Form
    {
        Usuarios _usuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarios = new Usuarios();
            listaUsuarioBindingSource.DataSource = _usuarios.ObtenerUsuarios();
        }
        #region "Mis Metodos"

        private void Formato()
        {
            //dGV1.Columns[0].Width = 80;
            //dGV1.Columns[0].HeaderText = "ID";
            //dGV1.Columns[1].Width = 120;
            //dGV1.Columns[1].HeaderText = "Codigo";
            //dGV1.Columns[2].Width = 80;
            //dGV1.Columns[2].HeaderText = "Nombre de Usuario";
            //dGV1.Columns[3].Width = 80;
            //dGV1.Columns[3].HeaderText = "Contraseña";
            //dGV1.Columns[4].Width = 80;
            //dGV1.Columns[4].HeaderText = "Confirmar Contraseña";
            //dGV1.Columns[5].Width = 80;
            //dGV1.Columns[5].HeaderText = "Rol";
            //dGV1.Columns[6].Width = 80;
            //dGV1.Columns[6].HeaderText = "Contraseña";
            //dGV1.Columns[7].Width = 80;
            //dGV1.Columns[7].HeaderText = "Rol";
        }

        private void Listado(string cTexto)
        {
            //UsuariosBD Datos = new UsuariosBD();
            //dGV1.DataSource = Datos.Listado(cTexto);
            //this.Formato();
        }      

        private void Estado_TextBox(bool estadoTextBox)
        {
            //nombreTextBox.ReadOnly = !estadoTextBox;
            //confirmarContrasenaTextBox.ReadOnly = !estadoTextBox;
            //nombreUsuarioTextBox.ReadOnly = !estadoTextBox;
            //contrasenaTextBox.ReadOnly = !estadoTextBox;
        }

        #endregion

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            //this.Listado("%");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.Listado("%" + Txtbuscar.Text.Trim() + "%");       
        }

        private void NuevoTextBox_Click(object sender, EventArgs e)
        {
            //this.Estado_TextBox(true);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContUsuarios Volver = new FrmContUsuarios();
            Volver.Show();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
