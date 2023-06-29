using MultiBodega_v1.Registro;
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

namespace MultiBodega_v1.Formularios_de_Registro
{
    public partial class FrmRegistrarProveedores : Form
    {


        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");

        public FrmRegistrarProveedores()
        {
            InitializeComponent();
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
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLE);

        }

        private void FrmRegistrarProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Proveedores' Puede moverla o quitarla según sea necesario.
            //this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombreProveedor = nombreProveedorTextBox.Text;
                char rtn[] = rTNTextBox.Text;
                string personaContacto = personaContactoTextBox.Text;
                string direccion = direccionTextBox.Text;
                string paisZona = pais_ZonaTextBox.Text;
                string tipoProveedor = tipo_ProveedorComboBox.Text;
                string numTelefono = num_TelefonoTextBox.Text;
                string correoElectronico = correoElectronicoTextBox.Text;
                string notas = notasTextBox.Text;
                bool activo = true;

                string connectionString = "Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;";
                SqlConnection connection = new SqlConnection(connectionString);
                {
                    connection.Open();
                    string query = "INSERT INTO Proveedores (NombreProveedor, RTN, PersonaContacto, Direccion, Pais_Zona, Tipo_Proveedor, Num_Telefono, CorreoElectronico, Notas, Activo) " +
                                   "VALUES (@nombreProveedor, @rtn, @personaContacto, @direccion, @paisZona, @tipoProveedor, @numTelefono, @correoElectronico, @notas, @activo)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
                        command.Parameters.AddWithValue("@rtn", rtn);
                        command.Parameters.AddWithValue("@personaContacto", personaContacto);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@paisZona", paisZona);
                        command.Parameters.AddWithValue("@tipoProveedor", tipoProveedor);
                        command.Parameters.AddWithValue("@numTelefono", numTelefono);
                        command.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                        command.Parameters.AddWithValue("@notas", notas);
                        command.Parameters.AddWithValue("@activo", activo);


                        command.ExecuteNonQuery();
                        MessageBox.Show("Los datos se han insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)
            {
                this.proveedoresTableAdapter.Eliminar(Convert.ToInt32(iDProveedorTextBox.Text));
                this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);

            }
        }

        private void nuevoRegistro_Click(object sender, EventArgs e)
        { 
            proveedoresBindingSource.AddNew();
        }

    }
}
