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
    public partial class FrmRegistrarPuntodeVenta : Form
    {

        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");


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
            EstablecerValorIDProducto();
        }

        private int ObtenerUltimoIDProducto()
        {
            // Realiza la consulta a la base de datos para obtener el último valor de IDProducto
            // Supongamos que utilizas una conexión a la base de datos llamada "conexion" y una consulta SQL adecuada para tu base de datos específica
            string consulta = "SELECT MAX(IDSolicitante) FROM RegistrarPuntodeVenta";
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

        private void EstablecerValorIDProducto()
        {
            int ultimoIDProducto = ObtenerUltimoIDProducto();
            int siguienteIDProducto = ultimoIDProducto + 1;
            iDSolicitanteTextBox.Text = siguienteIDProducto.ToString();
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
                EstablecerValorIDProducto();
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
