using MultiBodega_v1.Formularios_de_Registro;
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
    public partial class ModificarPuntodeVenta : Form
    {
        private string iD;
        private string FechaRegistro;
        private string Nombre;
        private string Lugar_Zona;
        private string Direccion;
        private string Num_Telefono;
        private string Notas;
        private bool Activo;

        public ModificarPuntodeVenta(string iD,  string FechaRegistro, string Nombre, string Lugar_Zona, string Direccion, string Num_Telefono, string Notas, bool Activo)
        {
            InitializeComponent();

            this.iD = iD;
            this.FechaRegistro = FechaRegistro;
            this.Nombre = Nombre;
            this.Lugar_Zona = Lugar_Zona;
            this.Direccion = Direccion;
            this.Num_Telefono = Num_Telefono;
            this.Notas = Notas;
            this.Activo = Activo;

            
            iDTextBox.Text = iD;
            fechaDateTimePicker.Text = FechaRegistro;
            nombreTextBox.Text = Nombre;
            lugar_ZonaTextBox.Text = Lugar_Zona;
            direccionTextBox.Text = Direccion;
            num_TelefonoTextBox.Text = Num_Telefono;
            notasTextBox.Text = Notas;
            activoCheckBox.Checked = Activo;

        }

        private void ModificarPuntodeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarPuntodeVenta' Puede moverla o quitarla según sea necesario.
            this.registrarPuntodeVentaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarPuntodeVenta);

        }

        private void ModificarPV_Click(object sender, EventArgs e)
        {
            DateTime FechaRegistro;

            if (DateTime.TryParse(fechaDateTimePicker.Value.ToString(), out FechaRegistro))
            {
                this.registrarPuntodeVentaTableAdapter.ActualizarPV( FechaRegistro.ToString(), @nombreTextBox.Text, lugar_ZonaTextBox.Text, @direccionTextBox.Text, @num_TelefonoTextBox.Text, 
                    @notasTextBox.Text, @activoCheckBox.Checked, Int32.Parse(@iDTextBox.Text));
                registrarPuntodeVentaTableAdapter.Fill(_CATELSA_MULTICABLE.RegistrarPuntodeVenta);
                MessageBox.Show("Se ha actualizado el registro");
                iDTextBox.Clear();
                fechaDateTimePicker.Value = DateTime.Now;
                nombreTextBox.Clear();
                lugar_ZonaTextBox.Clear();
                direccionTextBox.Clear();
                num_TelefonoTextBox.Clear();
                notasTextBox.Clear();
                activoCheckBox.Checked = false;
            }
            else
            {
                MessageBox.Show("Fecha Invalida");
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarPuntodeVenta listarPuntodeVenta = new FrmListarPuntodeVenta();
            listarPuntodeVenta.Show();
            this.Close();
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
