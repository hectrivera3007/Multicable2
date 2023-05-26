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

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked && checkBox2.Checked == true)
            {
                // Reemplaza la imagen de mostrar con la de ocultar desde los recursos del proyecto
                contrasenaTextBox.PasswordChar = '\0';
                checkBox2.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restaura la imagen de mostrar desde los recursos del proyecto
                contrasenaTextBox.PasswordChar = '●';
                checkBox2.Image = Properties.Resources.mostrar;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox1.Checked == true)
            {
                // Reemplaza la imagen de mostrar con la de ocultar desde los recursos del proyecto
                confirmarContrasenaTextBox.PasswordChar = '\0';
                checkBox1.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restaura la imagen de mostrar desde los recursos del proyecto
                confirmarContrasenaTextBox.PasswordChar = '●';
                checkBox1.Image = Properties.Resources.mostrar;
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
            this.usuarioTableAdapter.GuardarUsuario(nombreTextBox.Text, nombreUsuarioTextBox.Text, numTelefonoTextBox.Text,
                contrasenaTextBox.Text, confirmarContrasenaTextBox.Text, rolIDComboBox.SelectedIndex, activoCheckBox.Checked,
                bodegaIDComboBox.SelectedIndex);
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Usuario);
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
            //_usuarios.AgregarUsuario();
            //listaUsuarioBindingSource.MoveLast();
            //DeshabilitarHabilitarBotones(false);          
        }



        private void DeshabilitarHabilitarBotones(bool valor)
        {
            //bindingNavigatorMoveFirstItem.Enabled = valor;
            //bindingNavigatorMoveLastItem.Enabled = valor;
            //bindingNavigatorMovePreviousItem.Enabled = valor;
            //bindingNavigatorMoveNextItem.Enabled = valor;
            //bindingNavigatorPositionItem.Enabled = valor;

            //bindingNavigatorAddNewItem.Enabled = valor;
            //bindingNavigatorDeleteItem.Enabled = valor;
            //toolStripButtonCancelar.Visible = !valor;
        }

        private void listaUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //listaUsuarioBindingSource.EndEdit();
            //var usuario = (Usuario)listaUsuarioBindingSource.Current;

            //var resultado = _usuarios.GuardarUsuario(usuario);
            //if (resultado.Exito == true)
            //{
            //    listaUsuarioBindingSource.ResetBindings(false);
            //    DeshabilitarHabilitarBotones(true);
            //    MessageBox.Show("Usuario guardado Exitadamente");
            //}
            //else
            //{
            //    MessageBox.Show(resultado.Mensaje);
            //}
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Usuario);

        }
    }
}
