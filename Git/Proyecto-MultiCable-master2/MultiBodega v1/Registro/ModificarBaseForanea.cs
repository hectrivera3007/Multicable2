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
    public partial class ModificarBaseForanea : Form
    {
        private string idSolicitante;
        private string FechaRegistro;
        private string Nombre;
        private string Lugar_Zona;
        private string Dieccion;
        private string Num_Telefono;
        private string Notas;
        private bool Activo;
        

        public ModificarBaseForanea(string idSolicitante, string FechaRegistro, string Nombre, string Lugar_Zona, string Direccion, string Num_Telefono, string Notas, bool Activo)
        {
            InitializeComponent();
            this.idSolicitante = idSolicitante;
            this.FechaRegistro = FechaRegistro;
            this.Nombre = Nombre;
            this.Lugar_Zona = Lugar_Zona;
            this.Dieccion = Direccion;
            this.Num_Telefono = Num_Telefono;
            this.Notas = Notas;
            this.Activo = Activo;

            iDSolicitanteTextBox.Text = idSolicitante;
            FechaRegistroDateTimePicker.Text = FechaRegistro;
            nombreTextBox.Text = Nombre;
            lugar_ZonaTextBox.Text = Lugar_Zona;
            direccionTextBox.Text = Direccion;
            num_TelefonoTextBox.Text = Num_Telefono;
            notasTextBox.Text = Notas;
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
    }
}
