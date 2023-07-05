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
    public partial class FrmRegistrarPuntodeVenta : Form
    {
        public FrmRegistrarPuntodeVenta()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar Volver = new FrmRegistrar();
            Volver.Show();
        }

        private void FrmRegistrarPuntodeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarPuntodeVenta' Puede moverla o quitarla según sea necesario.
            this.registrarPuntodeVentaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarPuntodeVenta);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea Guardar este Registro?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.registrarPuntodeVentaTableAdapter.RegistrarPuntodeVenta(fechaRegistroDateTimePicker.Value, nombreTextBox.Text,
                lugar_ZonaTextBox.Text, direccionTextBox.Text, num_TelefonoTextBox.Text, notasTextBox.Text, activoCheckBox.Checked);
                this.registrarPuntodeVentaTableAdapter.Fill(_CATELSA_MULTICABLE.RegistrarPuntodeVenta);
                MessageBox.Show("El Registro ha sido Guardado con Éxito!");
                fechaRegistroDateTimePicker.ResetText();
                nombreTextBox.Clear();
                lugar_ZonaTextBox.Clear();
                direccionTextBox.Clear();
                num_TelefonoTextBox.Clear();
                notasTextBox.Clear();
                activoCheckBox.Checked = true;
            }
        }
    }
}
