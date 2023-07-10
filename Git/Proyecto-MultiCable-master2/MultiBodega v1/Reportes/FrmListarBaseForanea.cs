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
    public partial class FrmListarBaseForanea : Form
    {

        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA-MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion = new SqlConnection(ConexionString);


        public FrmListarBaseForanea()
        {
            InitializeComponent();
            RegistrarBaseForaneaDataGridView.CellDoubleClick += RegistrarBaseForaneaDataGridView_CellDoubleClick;
        }

        private void RegistrarBaseForaneaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = RegistrarBaseForaneaDataGridView.Rows[e.RowIndex];
            string idSolicitante = selectedRow.Cells[0].Value.ToString();
            string FechaRegistro = selectedRow.Cells[1].Value.ToString();
            string Nombre = selectedRow.Cells[2].Value.ToString();
            string Lugar_Zona = selectedRow.Cells[3].Value.ToString();
            string Direccion = selectedRow.Cells[4].Value.ToString();
            string Num_Telefono = selectedRow.Cells[5].Value.ToString();
                        string Notas = selectedRow.Cells[6].Value.ToString();
            bool Activo = Convert.ToBoolean(selectedRow.Cells[7].Value);

            // Abrir el formulario de modificación y pasar el registro seleccionado
            ModificarPuntodeVenta formModificar = new ModificarPuntodeVenta(idSolicitante, Nombre, FechaRegistro, Direccion, Num_Telefono, Lugar_Zona, Notas, Activo);
            formModificar.ShowDialog();
            this.Close();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmListar();
            Volver.Show();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            BuscarBase.Clear();
            BuscarBase.Focus();
        }

        private void FrmListarBaseForanea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarBaseForanea' Puede moverla o quitarla según sea necesario.
            this.registrarBaseForaneaTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarBaseForanea);

        }

        private void BuscarBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM RegistrarBaseForanea WHERE Nombre LIKE '%" + BuscarBase.Text + "%'";

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    RegistrarBaseForaneaDataGridView.DataSource = dt;
                    if (!string.IsNullOrEmpty(BuscarBase.Text))
                    {
                        RegistrarBaseForaneaDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                        RegistrarBaseForaneaDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                        RegistrarBaseForaneaDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                        RegistrarBaseForaneaDataGridView.Rows[0].DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold); // Establecer la fuente negrita solo para la primera fila
                    }
                    else
                    {
                        RegistrarBaseForaneaDataGridView.RowsDefaultCellStyle.BackColor = Color.Empty;
                        RegistrarBaseForaneaDataGridView.RowsDefaultCellStyle.ForeColor = Color.Empty;
                        RegistrarBaseForaneaDataGridView.RowsDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Regular); // Establecer la fuente regular para todas las filas
                    }
                }
                else
                {
                    RegistrarBaseForaneaDataGridView.DataSource = null; // Limpiar el DataGridView si no hay resultados
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

        private void RegistrarBaseForaneaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = RegistrarBaseForaneaDataGridView.Rows[e.RowIndex];

                // Seleccionar la fila completa
                selectedRow.Selected = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegistrarBaseForaneaDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = RegistrarBaseForaneaDataGridView.Rows[e.RowIndex];
            string idSolicitante = selectedRow.Cells[0].Value.ToString();
            string FechaRegistro = selectedRow.Cells[1].Value.ToString();
            string Nombre = selectedRow.Cells[2].Value.ToString();
            string Lugar_Zona = selectedRow.Cells[3].Value.ToString();
            string Direccion = selectedRow.Cells[4].Value.ToString();
            string Num_Telefono = selectedRow.Cells[5].Value.ToString();
            string Notas = selectedRow.Cells[6].Value.ToString();
            bool Activo = Convert.ToBoolean(selectedRow.Cells[7].Value.ToString());

            // Abrir el formulario de modificación y pasar el registro seleccionado
            ModificarBaseForanea formModificar = new ModificarBaseForanea(idSolicitante, FechaRegistro, Nombre, Lugar_Zona, Direccion, Num_Telefono, Notas, Activo);
            formModificar.ShowDialog();
            this.Close();
        }
    }
}
