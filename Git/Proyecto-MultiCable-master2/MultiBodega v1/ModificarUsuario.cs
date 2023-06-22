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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nom_Usuario = nombreUsuarioTextBox.Text;
            if (string.IsNullOrWhiteSpace(nom_Usuario))
            {
                MessageBox.Show("Por favor, ingrese un Nombre de Usuario válido.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nom_UsuarioExistente = _CATELSA_MULTICABLE.Usuario.AsEnumerable().Any(row => row.Field<string>("NombreUsuario") == nom_Usuario);

            if (nom_UsuarioExistente)
            {

                MessageBox.Show("El Nombre de Usuario que intenta guardar ya existe. Por favor, ingrese un Nombre de Usuario diferente.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea Guardar este Registro?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.usuarioTableAdapter.Guardar(nombreTextBox.Text, nombreUsuarioTextBox.Text, numTelefonoTextBox.Text,
                contrasenaTextBox.Text, confirmarContrasenaTextBox.Text, rolIDComboBox.SelectedIndex,
                bodegaIDComboBox.SelectedIndex, activoCheckBox.Checked);
                MessageBox.Show("¡El registro ha sido guardado con éxito!");
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLE);

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
            this.usuarioTableAdapter.ActualizaRegistro(@nombreTextBox.Text, @nombreUsuarioTextBox.Text, @numTelefonoTextBox.Text,
            @contrasenaTextBox.Text, @confirmarContrasenaTextBox.Text, @rolIDComboBox.SelectedIndex,
            @bodegaIDComboBox.SelectedIndex, @activoCheckBox.Checked, Int32.Parse(@iDTextBox.Text));
            this.usuarioTableAdapter.Fill(_CATELSA_MULTICABLE.Usuario);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
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
    }
}
