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

        private int ObtenerUltimoIDPrveedor()
        {
            // Realiza la consulta a la base de datos para obtener el último valor de IDProducto
            // Supongamos que utilizas una conexión a la base de datos llamada "conexion" y una consulta SQL adecuada para tu base de datos específica
            string consulta = "SELECT MAX(IDProveedor) FROM Proveedores";
            using (SqlCommand comando = new SqlCommand(consulta, Conexion))
            {
                Conexion.Open();
                // Ejecuta la consulta y obtén el resultado
                object resultado = comando.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    // Parsea el resultado a un entero y devuelve el valor
                    return Convert.ToInt32(resultado);
                }
            }
            
            // Si no se encuentra ningún valor, devuelve 0 o algún valor inicial apropiado
            return 0;
            //Conexion.Close();
        }

        private void EstablecerValorIDProveedor()
        {
            int ultimoIDProducto = ObtenerUltimoIDPrveedor();
            int siguienteIDProducto = ultimoIDProducto + 1;
            iDProveedorTextBox.Text = siguienteIDProducto.ToString();
        }


        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar VolverAtras = new FrmRegistrar();
            VolverAtras.Show();
        }

        

        private void FrmRegistrarProveedores_Load(object sender, EventArgs e)
        {
            EstablecerValorIDProveedor();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProveedor = nombreProveedorTextBox.Text;
            string rtn = tipo_ProveedorComboBox.Text == "Extranjero" ? "" : rTNTextBox.Text; // Verificar el valor del combobox y asignar un valor vacío si es "Extranjero"
            string personaContacto = personaContactoTextBox.Text;
            string direccion = direccionTextBox.Text;
            string paisZona = pais_ZonaTextBox.Text;
            string tipoProveedor = tipo_ProveedorComboBox.Text;
            string numTelefono = num_TelefonoTextBox.Text;
            string correoElectronico = correoElectronicoTextBox.Text;
            string notas = notasTextBox.Text;
            bool activo = true;

            string connectionString = "Server=(localdb)\\CATELSA;Database=CATELSA-MULTICABLE;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = "INSERT INTO Proveedores (NombreProveedor, RTN, PersonaContacto, Direccion, Pais_Zona, Tipo_Proveedor, Num_Telefono, CorreoElectronico, Notas, Activo) " +
                                       "VALUES (@nombreProveedor, @rtn, @personaContacto, @direccion, @paisZona, @tipoProveedor, @numTelefono, @correoElectronico, @notas, @activo)";
                        {

                        }
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
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
                        }

                        transaction.Commit();

                        MessageBox.Show("Los datos se han insertado correctamente.");

                        EstablecerValorIDProveedor();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        //transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
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



        //private void btnGuardar_Click(object sender, EventArgs e)
        //{

        //    // Crear un combo box que desplace RTN, DNI, DUI, DE LOS DIFERENTES PAISES Y QUE EL TAMAÑO DEL DATO SEA DEPENDIENDO EL TAMAÑO DE RTN, ETC.

        //    try
        //    {
        //        string nombreProveedor = nombreProveedorTextBox.Text;
        //        string rtn = rTNTextBox.Text;
        //        string personaContacto = personaContactoTextBox.Text;
        //        string direccion = direccionTextBox.Text;
        //        string paisZona = pais_ZonaTextBox.Text;
        //        string tipoProveedor = tipo_ProveedorComboBox.Text;
        //        string numTelefono = num_TelefonoTextBox.Text;
        //        string correoElectronico = correoElectronicoTextBox.Text;
        //        string notas = notasTextBox.Text;
        //        bool activo = true;

        //        string connectionString = "Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;";
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        {
        //            connection.Open();
        //            string query = "INSERT INTO Proveedores (NombreProveedor, RTN, PersonaContacto, Direccion, Pais_Zona, Tipo_Proveedor, Num_Telefono, CorreoElectronico, Notas, Activo) " +
        //                           "VALUES (@nombreProveedor, @rtn, @personaContacto, @direccion, @paisZona, @tipoProveedor, @numTelefono, @correoElectronico, @notas, @activo)";
        //            SqlCommand command = new SqlCommand(query, connection);

        //                command.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
        //                command.Parameters.AddWithValue("@rtn", rtn);
        //                command.Parameters.AddWithValue("@personaContacto", personaContacto);
        //                command.Parameters.AddWithValue("@direccion", direccion);
        //                command.Parameters.AddWithValue("@paisZona", paisZona);
        //                command.Parameters.AddWithValue("@tipoProveedor", tipoProveedor);
        //                command.Parameters.AddWithValue("@numTelefono", numTelefono);
        //                command.Parameters.AddWithValue("@correoElectronico", correoElectronico);
        //                command.Parameters.AddWithValue("@notas", notas);
        //                command.Parameters.AddWithValue("@activo", activo);
        //                //proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);
        //                EstablecerValorIDProducto();
        //                LimpiarCampos();
        //                nombreProveedorTextBox.Clear();
        //                rTNTextBox.Clear();
        //                personaContactoTextBox.Clear();
        //                direccionTextBox.Clear();
        //                pais_ZonaTextBox.Clear();
        //                tipo_ProveedorComboBox.SelectedIndex = -1;
        //                num_TelefonoTextBox.Clear();
        //                correoElectronicoTextBox.Clear();
        //                notasTextBox.Clear();
        //                activoCheckBox.Checked = true;

        //                command.ExecuteNonQuery();
        //                MessageBox.Show("Los datos se han insertado correctamente.");

        //            connection.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Error: " + ex.Message);
        //    }

        //}

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
