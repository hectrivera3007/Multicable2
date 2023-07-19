using MultiBodega_v1.Listar;
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
    public partial class FrmListarTecnicos : Form
    {

        SqlConnection conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");
        private DataGridViewRow selectedRow;

        public FrmListarTecnicos()
        {
            InitializeComponent();
            ListarTecnicosDataGridView.CellDoubleClick += ListarTecnicosDataGridView_CellContentDoubleClick;
            
        }

        private void FrmListarTecnicos_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            //this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
            //// TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            //this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
            string consulta = "Exec LISTARTECNICOS";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            ListarTecnicosDataGridView.DataSource = dt;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From RegistrarTecnicos Where Nombres like ('%" + BuscarTecnico.Text + "%') OR Apellidos LIKE ('%" + BuscarTecnico.Text + "%') OR DNI LIKE ('%" + BuscarTecnico.Text + "%')";

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    ListarTecnicosDataGridView.DataSource = dt;
                    if (!string.IsNullOrEmpty(BuscarTecnico.Text))
                    {
                        ListarTecnicosDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        ListarTecnicosDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                        ListarTecnicosDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                        ListarTecnicosDataGridView.Rows[0].DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold); // Establecer la fuente negrita solo para la primera fila
                    }
                    else
                    {
                        ListarTecnicosDataGridView.RowsDefaultCellStyle.BackColor = Color.Empty;
                        ListarTecnicosDataGridView.RowsDefaultCellStyle.ForeColor = Color.Empty;
                        ListarTecnicosDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                    }
                }
                else
                {
                    ListarTecnicosDataGridView.DataSource = null; // Limpiar el DataGridView si no hay resultados
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

        private void Limpiar_Click(object sender, EventArgs e)
        {
            BuscarTecnico.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmListar();
            Volver.Show();
        }

        private void ListarTecnicosDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = ListarTecnicosDataGridView.Rows[e.RowIndex];
            int idSolicitante = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            DateTime fecha = DateTime.Parse(selectedRow.Cells[1].Value.ToString());
            string nombres = selectedRow.Cells[2].Value.ToString();
            string apellido = selectedRow.Cells[3].Value.ToString();
            string dni = selectedRow.Cells[4].Value.ToString();
            string direccion = selectedRow.Cells[5].Value.ToString();
            string numTelefono = selectedRow.Cells[6].Value.ToString();
            string notas = selectedRow.Cells[8].Value.ToString();
            bool activo = Convert.ToBoolean(selectedRow.Cells[9].Value);

            // Abrir el formulario de modificación y pasar el registro seleccionado
            ModificarTecnico formModificar = new ModificarTecnico(idSolicitante, fecha, nombres, apellido, dni, direccion, numTelefono, notas, activo);
            formModificar.ShowDialog();
        }
    }
}
