using MultiBodega_v1.Listar;
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
    public partial class FrmListarPuntodeVenta : Form
    {

        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA-MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion = new SqlConnection(ConexionString);

        public FrmListarPuntodeVenta()
        {
            InitializeComponent();
        }

        private void FrmListarPuntodeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarPuntodeVenta' Puede moverla o quitarla según sea necesario.
            this.registrarPuntodeVentaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarPuntodeVenta);

        }

        private void BuscarPuntos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM RegistrarPuntodeVenta WHERE Nombre LIKE '%" + BuscarPuntos.Text + "%'";

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    RegistrarPuntodeVentaDataGridView.DataSource = dt;
                    if (!string.IsNullOrEmpty(BuscarPuntos.Text))
                    {
                        RegistrarPuntodeVentaDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        RegistrarPuntodeVentaDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                        RegistrarPuntodeVentaDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                        RegistrarPuntodeVentaDataGridView.Rows[0].DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold); // Establecer la fuente negrita solo para la primera fila
                    }
                    else
                    {
                        RegistrarPuntodeVentaDataGridView.RowsDefaultCellStyle.BackColor = Color.Empty;
                        RegistrarPuntodeVentaDataGridView.RowsDefaultCellStyle.ForeColor = Color.Empty;
                        RegistrarPuntodeVentaDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                    }
                }
                else
                {
                    RegistrarPuntodeVentaDataGridView.DataSource = null; // Limpiar el DataGridView si no hay resultados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda de Bases Foráneas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmListar();
            Volver.Show();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            BuscarPuntos.Clear();
        }
    }
}
