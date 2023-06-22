using MultiBodega_v1.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Formularios_de_Registro
{
    public partial class FrmRegistrarProveedores : Form
    {
        public FrmRegistrarProveedores()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar VolverAtras = new FrmRegistrar();
            VolverAtras.Show();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLE);

        }

        private void FrmRegistrarProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Proveedores1' Puede moverla o quitarla según sea necesario.
            //this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Guardar(nombreProveedorTextBox.Text, Int32.Parse(rTNTextBox1.Text),
                personaContactoTextBox.Text, direccionTextBox.Text, pais_ZonaTextBox.Text,tipo_ProveedorComboBox.Text,
                num_TelefonoTextBox.Text, correoElectronicoTextBox.Text, notasTextBox.Text, activoCheckBox.Checked);
            this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);
            MessageBox.Show("El registro se ha guardado con éxito..!");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.proveedoresTableAdapter.Eliminar(Convert.ToInt32(iDProveedorTextBox.Text));
                this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);

            }
        }

        private void nuevoRegistro_Click(object sender, EventArgs e)
        { 
            proveedoresBindingSource.AddNew();
        }
    }
}
