using MultiBodega_v1.Listar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using MultiBodega_v1.Registro;

namespace MultiBodega_v1.Inventario
{
    public partial class FrmListarProveedor : Form
    {

        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA-MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion = new SqlConnection(ConexionString);
        private DataGridViewRow selectedRow;

        public FrmListarProveedor()
        {
            InitializeComponent();
            proveedoresDataGridView.CellDoubleClick += proveedoresDataGridView_CellContentDoubleClick;
        }

        private void FrmListarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Proveedores' Puede moverla o quitarla según sea necesario.
            //this.proveedoresTableAdapter.Fill(this._CATELSA_MULTICABLE.Proveedores);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Proveedores1' Puede moverla o quitarla según sea necesario.
            //this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);
            string consulta = "Exec ListarProveedores";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            proveedoresDataGridView.DataSource = dt;

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmListar();
            Volver.Show();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            BuscarProveedor.Clear();
        }


        private void BuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Proveedores WHERE NombreProveedor LIKE '%" + BuscarProveedor.Text + "%'";

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    proveedoresDataGridView.DataSource = dt;
                    if (!string.IsNullOrEmpty(BuscarProveedor.Text))
                    {
                        proveedoresDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        proveedoresDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                        proveedoresDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                        proveedoresDataGridView.Rows[0].DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold); // Establecer la fuente negrita solo para la primera fila
                    }
                    else
                    {
                        proveedoresDataGridView.RowsDefaultCellStyle.BackColor = Color.Empty;
                        proveedoresDataGridView.RowsDefaultCellStyle.ForeColor = Color.Empty;
                        proveedoresDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                    }
                }
                else
                {
                    proveedoresDataGridView.DataSource = null; // Limpiar el DataGridView si no hay resultados
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

        private void proveedoresDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = proveedoresDataGridView.Rows[e.RowIndex];
            string iDProveedor = selectedRow.Cells[0].Value.ToString();
            string NombreProveedor = selectedRow.Cells[1].Value.ToString();
            string RTN = selectedRow.Cells[2].Value.ToString();
            string personaContacto = selectedRow.Cells[3].Value.ToString();
            string Direccion = selectedRow.Cells[4].Value.ToString();
            string pais_Zona = selectedRow.Cells[5].Value.ToString();
            string tipo_Proveedor = selectedRow.Cells[6].Value.ToString();
            string num_Telefono = selectedRow.Cells[7].Value.ToString();
            string correoElectronico = selectedRow.Cells[8].Value.ToString();
            string notas = selectedRow.Cells[9].Value.ToString();
            bool Activo = Convert.ToBoolean(selectedRow.Cells[10].Value);

            // Abrir el formulario de modificación y pasar el registro seleccionado
            ModificarProveedor formModificar = new ModificarProveedor(iDProveedor, NombreProveedor, RTN, personaContacto, pais_Zona, Direccion, tipo_Proveedor, num_Telefono, correoElectronico, notas, Activo);
            formModificar.ShowDialog();
        }
    }
}