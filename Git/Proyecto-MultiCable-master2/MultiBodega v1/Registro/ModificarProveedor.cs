using MultiBodega_v1.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Registro
{
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarProveedor listarProveedores = new FrmListarProveedor();
            listarProveedores.Show();
            this.Close();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.ModificarProveedor(@nombreProveedorTextBox.Text, @rTNTextBox.Text, @personaContactoTextBox.Text, @direccionTextBox.Text,
                @pais_ZonaTextBox.Text, @tipo_ProveedorComboBox.Text, @num_TelefonoTextBox.Text, @correoElectronicoTextBox.Text, @notasTextBox.Text,
                @activoCheckBox.Checked, Int32.Parse(@iDProveedorTextBox.Text));
            MessageBox.Show("El registro ha sido actualizado");
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLE);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                   "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.proveedoresTableAdapter.Eliminar(Int32.Parse(iDProveedorTextBox.Text)); // Eliminamos el registro
                this.proveedoresTableAdapter.Fill(_CATELSA_MULTICABLE.Proveedores); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            iDProveedorTextBox.Clear();
            nombreProveedorTextBox.Clear();
            rTNTextBox.Clear();
            personaContactoTextBox.Clear();
            direccionTextBox.Clear();
            pais_ZonaTextBox.Clear();
            tipo_ProveedorComboBox.SelectedIndex = -1;
            num_TelefonoTextBox.Clear();
            correoElectronicoTextBox.Clear();
            notasTextBox.Clear();
            activoCheckBox.Checked = false;
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
    }
}
