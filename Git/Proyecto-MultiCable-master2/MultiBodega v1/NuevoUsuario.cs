using BL.Bodega;
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
    public partial class NuevoUsuario : Form
    {
        

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContUsuarios Volver = new FrmContUsuarios();
            Volver.Show();
        }
        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (activoCheckBox.Checked)
            {
                activoCheckBox.ForeColor = Color.Green;
            }
            else
            {
                activoCheckBox.ForeColor = Color.Black;
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Rol);
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Usuario);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            this.usuarioTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Usuario);
        }

        private void ckContraseña_CheckedChanged(object sender, EventArgs e)
        {

            if (ckContraseña.Checked)
            {
                // Reemplaza la imagen de mostrar con la de ocultar desde los recursos del proyecto
                contrasenaTextBox.UseSystemPasswordChar = false;
                ckContraseña.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restaura la imagen de mostrar desde los recursos del proyecto
                contrasenaTextBox.UseSystemPasswordChar = true;
                ckContraseña.Image = Properties.Resources.mostrar;
            }

        }
        private void ckConfirmarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckConfirmarContra.Checked)
            {
                // Reemplaza la imagen de mostrar con la de ocultar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = false;
                ckConfirmarContra.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restaura la imagen de mostrar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = true;
                ckConfirmarContra.Image = Properties.Resources.mostrar;
            }
        }
    }
}
