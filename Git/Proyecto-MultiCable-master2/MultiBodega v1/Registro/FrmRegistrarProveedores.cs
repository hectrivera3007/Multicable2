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
            this.proveedores1BindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLEDataSet);

        }

        private void FrmRegistrarProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Proveedores1' Puede moverla o quitarla según sea necesario.
            //this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*this.proveedores1TableAdapter.GuardarProveedor(nombreProveedorTextBox.Text, rTNTextBox1.Text,
                personaContactoTextBox.Text, direccionTextBox.Text, pais_ZonaTextBox.Text,tipo_ProveedorComboBox.Text,
                num_TelefonoTextBox.Text, correoElectronicoTextBox.Text, notasTextBox.Text);
            this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);
            */
            MessageBox.Show("El registro se ha guardado con éxito..!");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //this.proveedores1TableAdapter.EliminarRegistro(iDProveedorTextBox.Text);
            //this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);
        }

        private void nuevoRegistro_Click(object sender, EventArgs e)
        { 
            proveedores1BindingSource.AddNew();
        }
    }
}
