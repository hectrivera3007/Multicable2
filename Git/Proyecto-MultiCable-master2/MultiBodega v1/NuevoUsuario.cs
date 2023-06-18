using BL.Bodega;
using MultiBodega_v1.BD_CATELSA_MULTICABLETableAdapters;
using MultiBodega_v1.Botonera;
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


namespace MultiBodega_v1
{
    public partial class NuevoUsuario : Form
    {
        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA - MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion =new SqlConnection(ConexionString);

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContUsuarios Volver = new FrmContUsuarios();
            Volver.Show();
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

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLE.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLE.Usuario);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            string nom_Usuario = nombreUsuarioTextBox.Text;
            if (string.IsNullOrWhiteSpace(nom_Usuario))
            {
                MessageBox.Show("Por favor, ingrese un Nombre de Usuario válido.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nom_UsuarioExistente = _CATELSA_MULTICABLE.Usuario.AsEnumerable().Any(row => row.Field<string>("NombreUsuario") == nom_Usuario);

            if (nom_UsuarioExistente)
            {

                MessageBox.Show("El Nombre de Usuario que intenta guardar ya existe. Por favor, ingrese un Nombre de Usuario diferente.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea Guardar este Registro?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.usuarioTableAdapter.Guardar(nombreTextBox.Text, nombreUsuarioTextBox.Text, numTelefonoTextBox.Text,
                contrasenaTextBox.Text, confirmarContrasenaTextBox.Text, rolIDComboBox.SelectedIndex,
                bodegaIDComboBox.SelectedIndex, activoCheckBox.Checked);
            }
        }

        private void ckContraseña_CheckedChanged(object sender, EventArgs e)
        {

            if (ckContraseña.Checked)
            {
                // Reemplaza la imagen de mostrar con la de ocultar desde los recursos del proyecto
                contrasenaTextBox.UseSystemPasswordChar = false;
                ckContraseña.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restaura la imagen de mostrar desde los recursos del proyecto
                contrasenaTextBox.UseSystemPasswordChar = true;
                ckContraseña.Image = Properties.Resources.mostrar;
            }

        }
        private void ckConfirmarContra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckConfirmarContra.Checked)
            {
                // Reemplazamos la imagen de mostrar con la de ocultar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = false;
                ckConfirmarContra.Image = Properties.Resources.esconder;
            }
            else
            {
                // Restauramos la imagen de mostrar desde los recursos del proyecto
                confirmarContrasenaTextBox.UseSystemPasswordChar = true;
                ckConfirmarContra.Image = Properties.Resources.mostrar;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            this.usuarioTableAdapter.Guardar(nombreTextBox.Text, nombreUsuarioTextBox.Text, numTelefonoTextBox.Text,
            contrasenaTextBox.Text, confirmarContrasenaTextBox.Text, rolIDComboBox.SelectedIndex,
            bodegaIDComboBox.SelectedIndex, activoCheckBox.Checked);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Le preguntamos al usuario si en verdad quiere eliminar el registro.
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.usuarioTableAdapter.Eliminar(Int32.Parse(iDTextBox.Text)); // Eliminamos el registro
                this.usuarioTableAdapter.Fill(_CATELSA_MULTICABLE.Usuario); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            iDTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            numTelefonoTextBox.Clear();
            contrasenaTextBox.Clear();
            confirmarContrasenaTextBox.Clear();
            rolIDComboBox.SelectedIndex = -1;
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            iDTextBox.Clear();
            nombreTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            numTelefonoTextBox.Clear();
            contrasenaTextBox.Clear();
            confirmarContrasenaTextBox.Clear();
            rolIDComboBox.SelectedIndex = -1;
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = false;
        }
    }
}
