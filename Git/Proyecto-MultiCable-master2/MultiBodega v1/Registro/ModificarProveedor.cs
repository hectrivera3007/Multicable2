using MultiBodega_v1.Inventario;
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
    public partial class ModificarProveedor : Form
    {

        private string iDProveedor;
        private string NombreProveedor;
        private string RTN;
        private string personaContacto;
        private string Direccion;
        private string pais_Zona;
        private string tipo_Proveedor;
        private string num_Telefono;
        private string correoElectronico;
        private string notas;
        private bool Activo;

        public ModificarProveedor(string iDProveedor, string NombreProveedor, string RTN, string personaContacto, string pais_Zona, string Direccion, string tipo_Proveedor, string num_Telefono, string correoElectronico, string notas, bool Activo)
        {
            InitializeComponent();


            this.iDProveedor = iDProveedor;
            this.NombreProveedor = NombreProveedor;
            this.RTN = RTN;
            this.personaContacto = personaContacto;
            this.Direccion = Direccion;
            this.pais_Zona = pais_Zona;
            this.tipo_Proveedor = tipo_Proveedor;
            this.num_Telefono = num_Telefono;
            this.correoElectronico = correoElectronico;
            this.notas = notas;
            this.Activo = Activo;

            iDProveedorTextBox.Text = iDProveedor;
            nombreProveedorTextBox.Text = NombreProveedor;
            rTNTextBox.Text = RTN;
            personaContactoTextBox.Text = personaContacto;
            direccionTextBox.Text = Direccion;
            pais_ZonaTextBox.Text = pais_Zona;
            tipo_ProveedorComboBox.Text = tipo_Proveedor;
            num_TelefonoTextBox.Text = num_Telefono;
            correoElectronicoTextBox.Text = correoElectronico;
            notasTextBox.Text = notas;
            activoCheckBox.Checked = Activo;

        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarPuntodeVenta' Puede moverla o quitarla según sea necesario.
            //this.proveedoresTableAdapter.Fill(_CATELSA_MULTICABLE.Proveedores);

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.ModificarProveedor(@nombreProveedorTextBox.Text, @rTNTextBox.Text, @personaContactoTextBox.Text, @direccionTextBox.Text,
                @pais_ZonaTextBox.Text, @tipo_ProveedorComboBox.Text, @num_TelefonoTextBox.Text, @correoElectronicoTextBox.Text, @notasTextBox.Text,
                @activoCheckBox.Checked, Int32.Parse(@iDProveedorTextBox.Text));
            MessageBox.Show("El registro ha sido actualizado");
            iDProveedorTextBox.Clear();
            nombreProveedorTextBox.Clear();
            rTNTextBox.Clear();
            personaContactoTextBox.Clear();
            direccionTextBox.Clear();
            pais_ZonaTextBox.Clear();
            tipo_ProveedorComboBox.SelectedIndex = -1;
            num_TelefonoTextBox.Clear();
            correoElectronicoTextBox.Clear();
            notasTextBox.Clear();
            activoCheckBox.Checked = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                   "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.proveedoresTableAdapter.Eliminar(Int32.Parse(iDProveedorTextBox.Text)); // Eliminamos el registro
                this.proveedoresTableAdapter.Fill(_CATELSA_MULTICABLE.Proveedores); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            iDProveedorTextBox.Clear();
            nombreProveedorTextBox.Clear();
            rTNTextBox.Clear();
            personaContactoTextBox.Clear();
            direccionTextBox.Clear();
            pais_ZonaTextBox.Clear();
            tipo_ProveedorComboBox.SelectedIndex = -1;
            num_TelefonoTextBox.Clear();
            correoElectronicoTextBox.Clear();
            notasTextBox.Clear();
            activoCheckBox.Checked = false;
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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmListarProveedor listarProveedor = new FrmListarProveedor();
            listarProveedor.Show();
            this.Close();
        }
    }
}
