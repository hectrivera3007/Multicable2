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
    public partial class ModificarBaseForanea : Form
    {
        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");


        private string idBF;
        private DateTime FechaRegistro;
        private string Nombre;
        private string Lugar_Zona;
        private string Dieccion;
        private string Num_Telefono;
        private string Notas;
        private bool Activo;
        

        public ModificarBaseForanea(string idBF, DateTime FechaRegistro, string Nombre, string Lugar_Zona, string Direccion, string Num_Telefono, string Notas, bool Activo)
        {
            InitializeComponent();

            this.idBF = idBF;
            this.FechaRegistro = FechaRegistro;
            this.Nombre = Nombre;
            this.Lugar_Zona = Lugar_Zona;
            this.Dieccion = Direccion;
            this.Num_Telefono = Num_Telefono;
            this.Notas = Notas;
            this.Activo = Activo;

            iDBFTextBox.Text = idBF;
            FechaRegistroBFDateTimePicker.Value = FechaRegistro;
            nombreBFTextBox.Text = Nombre;
            lugar_ZonaBFTextBox.Text = Lugar_Zona;
            direccionBFTextBox.Text = Direccion;
            num_TelefonoBFTextBox.Text = Num_Telefono;
            notasBFTextBox.Text = Notas;
            activoCheckBox.Checked = Activo;
        }

        private void ModificarBaseForanea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarBaseForanea' Puede moverla o quitarla según sea necesario.
            this.registrarBaseForaneaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarBaseForanea);
            
        }        

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarBaseForanea nuevo = new FrmListarBaseForanea();
            nuevo.Show();
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

        private void BtnModificarBF_Click(object sender, EventArgs e)
        {
            DateTime FechaRegistro;

            if (DateTime.TryParse(FechaRegistroBFDateTimePicker.Value.ToString(), out FechaRegistro))
            {
                this.registrarBaseForaneaTableAdapter.ActualizarBF(FechaRegistro.ToString(), nombreBFTextBox.Text,lugar_ZonaBFTextBox.Text,direccionBFTextBox.Text,num_TelefonoBFTextBox.Text,
                notasBFTextBox.Text,activoCheckBox.Checked, Convert.ToInt32(iDBFTextBox.Text));
                registrarBaseForaneaTableAdapter.Fill(_CATELSA_MULTICABLE.RegistrarBaseForanea);
                MessageBox.Show("Se ha actualizado el registro");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Fecha Invalida");
            }
        }

        private void Limpiar()
        {
            iDBFTextBox.Clear();
            FechaRegistroBFDateTimePicker.Value = DateTime.Now;
            nombreBFTextBox.Clear();
            lugar_ZonaBFTextBox.Clear();
            direccionBFTextBox.Clear();
            num_TelefonoBFTextBox.Clear();
            notasBFTextBox.Clear();
            activoCheckBox.Checked = true;
        }
    }
}
