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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

       

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLE.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLE.Usuario);

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Modificar(@fechaActivacionDateTimePicker.Value, @nombreTextBox.Text, @nombreUsuarioTextBox.Text, @numTelefonoTextBox.Text,
            @contrasenaTextBox.Text, @confirmarContrasenaTextBox.Text, @rolIDComboBox.SelectedIndex+1,
            bodegaIDComboBox.SelectedIndex+1, @activoCheckBox.Checked, Int32.Parse(iDTextBox.Text));
            this.usuarioTableAdapter.Fill(_CATELSA_MULTICABLE.Usuario);
            FrmUsuarios nuevo = new FrmUsuarios();
            nuevo.Show();
            //Limpiamos los TextBox luego de Modificar el registro de Rol de Usuario.            
            iDTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            numTelefonoTextBox.Clear();
            contrasenaTextBox.Clear();
            confirmarContrasenaTextBox.Clear();
            rolIDComboBox.SelectedIndex = -1;
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.usuarioTableAdapter.Eliminar(Int32.Parse(iDTextBox.Text)); // Eliminamos el registro
                this.usuarioTableAdapter.Fill(_CATELSA_MULTICABLE.Usuario); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            iDTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            numTelefonoTextBox.Clear();
            contrasenaTextBox.Clear();
            confirmarContrasenaTextBox.Clear();
            rolIDComboBox.SelectedIndex = -1;
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = false;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUsuarios nuevo = new FrmUsuarios();
            nuevo.Show();
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
                // Reemplazamos la imagen de mostrar con la de ocultar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = false;
                ckConfirmarContra.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restauramos la imagen de mostrar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = true;
                ckConfirmarContra.Image = Properties.Resources.mostrar;
            }
        }
    }
}
