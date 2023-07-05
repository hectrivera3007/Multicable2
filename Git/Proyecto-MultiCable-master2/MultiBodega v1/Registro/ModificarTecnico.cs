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
    public partial class ModificarTecnico : Form
    {
        private string id;
        private string fecha;
        private string nombres;
        private string apellido;
        private string dni;
        private string direccion;
        private string numTelefono;
        private string notas;
        private bool activo;

        public ModificarTecnico(string id, string fecha, string nombres, string apellido, string dni, string direccion, string numTelefono, string notas, bool activo)
        {
            InitializeComponent();

            // Asignar los valores recibidos a las variables privadas
            this.id = id;
            this.fecha = fecha;
            this.nombres = nombres;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.numTelefono = numTelefono;
            this.notas = notas;
            this.activo = activo;

            // Aquí puedes usar las variables para cargar los datos en los controles del formulario
            iDSolicitanteTextBox.Text = id;
            fechaDateTimePicker.Text = fecha;
            nombresTextBox.Text = nombres;
            apellidoTextBox.Text = apellido;
            dNITextBox.Text = dni;
            direccionTextBox.Text = direccion;
            num_TelefonoTextBox.Text = numTelefono;
            notasTextBox.Text = notas;
            activoCheckBox.Checked = activo;
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

        private void ModificarTecnico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarTecnicos nuevo = new FrmListarTecnicos();
            nuevo.Show();
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DateTime fecha;

            if (DateTime.TryParse(fechaDateTimePicker.Value.ToString(), out fecha))
            {
                this.registrarTecnicosTableAdapter.ModificarTecnicos(fecha.ToString(), @nombresTextBox.Text, @apellidoTextBox.Text, @dNITextBox.Text, @direccionTextBox.Text,
                @num_TelefonoTextBox.Text, @notasTextBox.Text, @activoCheckBox.Checked, Int32.Parse(@iDSolicitanteTextBox.Text));
                registrarTecnicosTableAdapter.Fill(_CATELSA_MULTICABLE.RegistrarTecnicos);
                MessageBox.Show("Se ha actualizado el registro");
            }
            else
            {
                MessageBox.Show("Fecha Invalida");
            }


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            registrarTecnicosTableAdapter.EliminarTecnico(Int32.Parse(iDSolicitanteTextBox.Text));
            MessageBox.Show("El Registro ha sido Eliminado!");
        }
    }
}
