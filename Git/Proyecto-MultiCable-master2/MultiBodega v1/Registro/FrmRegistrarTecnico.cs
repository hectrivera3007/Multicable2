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
    public partial class FrmRegistrarTecnico : Form
    {
        public FrmRegistrarTecnico()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar Volver = new FrmRegistrar();
            Volver.Show();
        }

        private void FrmRegistrarTecnico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            //this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.RegistrarTecnicos);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea Guardar este Registro?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.registrarTecnicosTableAdapter.RegistrarTecnico(fechaDateTimePicker.Value, nombresTextBox.Text, apellidoTextBox.Text, dNITextBox.Text,
                direccionTextBox.Text, num_TelefonoTextBox.Text, notasTextBox.Text, activoCheckBox.Checked);
                this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
                MessageBox.Show("El registro se ha guardado correctamente");
            }
        }

        private void nuevoTextBox_Click(object sender, EventArgs e)
        {

        }

        private void registrarTecnicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrarTecnicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLE);

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
