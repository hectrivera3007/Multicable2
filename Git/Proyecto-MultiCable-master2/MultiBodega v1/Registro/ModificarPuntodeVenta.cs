using MultiBodega_v1.Formularios_de_Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Registro
{
    public partial class ModificarPuntodeVenta : Form
    {

        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");


        private string iD;
        private DateTime FechaRegistro;
        private string Nombre;
        private string Lugar_Zona;
        private string Direccion;
        private string Num_Telefono;
        private string Notas;
        private bool Activo;

        public ModificarPuntodeVenta(string iD, DateTime FechaRegistro, string Nombre, string Lugar_Zona, string Direccion, string Num_Telefono, string Notas, bool Activo)
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

            
            iDPVTextBox.Text = iD;
            fechaPVDateTimePicker.Value = DateTime.Parse(FechaRegistro.ToString("dd-MM-yyyy"));
            nombrePVTextBox.Text = Nombre;
            lugar_ZonaPVTextBox.Text = Lugar_Zona;
            direccionPVTextBox.Text = Direccion;
            num_TelefonoPVTextBox.Text = Num_Telefono;
            notasPVTextBox.Text = Notas;
            activoCheckBox.Checked = Activo;

        }

        private void ModificarPuntodeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarPuntodeVenta' Puede moverla o quitarla según sea necesario.
            this.registrarPuntodeVentaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarPuntodeVenta);
            
        }

        private void ModificarPV_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FechaRegistro;

                if (DateTime.TryParse(fechaPVDateTimePicker.Value.ToString(), out FechaRegistro))
                {
                    this.registrarPuntodeVentaTableAdapter.ActualizarPV(FechaRegistro.ToString(), nombrePVTextBox.Text, lugar_ZonaPVTextBox.Text, direccionPVTextBox.Text, num_TelefonoPVTextBox.Text,
                        notasPVTextBox.Text, @activoCheckBox.Checked, Int32.Parse(iDPVTextBox.Text));
                    registrarPuntodeVentaTableAdapter.Fill(_CATELSA_MULTICABLE.RegistrarPuntodeVenta);
                    MessageBox.Show("Se ha actualizado el registro");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Fecha Invalida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" "+ex.ToString());
            }
            
        }

        private void Limpiar()
        {
            iDPVTextBox.Clear();
            fechaPVDateTimePicker.Value = DateTime.Now;
            nombrePVTextBox.Clear();
            lugar_ZonaPVTextBox.Clear();
            direccionPVTextBox.Clear();
            num_TelefonoPVTextBox.Clear();
            notasPVTextBox.Clear();
            activoCheckBox.Checked = false;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarPuntodeVenta listarPuntodeVenta = new FrmListarPuntodeVenta();
            listarPuntodeVenta.Show();
            this.Close();
        }

        private void activoCheckBox_CheckedChanged_1(object sender, EventArgs e)
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
