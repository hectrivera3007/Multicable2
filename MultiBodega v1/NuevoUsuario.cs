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
        Usuarios _usuarios;

        public NuevoUsuario()
        {
            InitializeComponent();
            _usuarios = new Usuarios();
            listaUsuarioBindingSource.DataSource = _usuarios.ObtenerUsuarios();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                contrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                contrasenaTextBox.PasswordChar = '●';
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                confirmarContrasenaTextBox.PasswordChar = '\0';
            }
            else
            {
                confirmarContrasenaTextBox.PasswordChar = '●';
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContUsuarios Volver = new FrmContUsuarios();
            Volver.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuarios.AgregarUsuario();
            listaUsuarioBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);          
        }



        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listaUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuarioBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuarioBindingSource.Current;

            var resultado = _usuarios.GuardarUsuario(usuario);
            if (resultado.Exito == true)
            {
                listaUsuarioBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado Exitadamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }
    }
}
