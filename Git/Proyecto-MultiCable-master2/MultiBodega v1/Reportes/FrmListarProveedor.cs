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
using MultiBodega_v1.Registro;

namespace MultiBodega_v1.Inventario
{
    public partial class FrmListarProveedor : Form
    {

        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA-MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion = new SqlConnection(ConexionString);

        public FrmListarProveedor()
        {
            InitializeComponent();
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
                    proveedoresDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CadetBlue;
                    proveedoresDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    proveedoresDataGridView.DataSource = null; // Limpiar el DataGridView si no hay resultados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda de proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
            
        }

        private void proveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                //Mostrar el formulario de tu elección
                DataGridViewRow row = proveedoresDataGridView.CurrentRow;
                ModificarProveedor Mostrar = new ModificarProveedor();
                Mostrar.iDProveedorTextBox.Text = row.Cells[1].Value.ToString();
                Mostrar.nombreProveedorTextBox.Text = row.Cells[2].Value.ToString();
                Mostrar.rTNTextBox.Text = row.Cells[3].Value.ToString();
                Mostrar.personaContactoTextBox.Text = row.Cells[4].Value.ToString();
                Mostrar.direccionTextBox.Text = row.Cells[5].Value.ToString();
                Mostrar.pais_ZonaTextBox.Text = row.Cells[6].Value.ToString();
                Mostrar.tipo_ProveedorComboBox.Text = row.Cells[7].Value.ToString();
                Mostrar.num_TelefonoTextBox.Text = row.Cells[8].Value.ToString();
                Mostrar.correoElectronicoTextBox.Text = row.Cells[9].Value.ToString();
                Mostrar.notasTextBox.Text = row.Cells[10].Value.ToString();
                Mostrar.activoCheckBox.Checked = (bool)row.Cells[11].Value;
                this.Close();
                Mostrar.ShowDialog();
            }
        }
    }
}