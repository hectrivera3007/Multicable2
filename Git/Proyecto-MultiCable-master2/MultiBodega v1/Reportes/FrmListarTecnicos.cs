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
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(BuscarTecnico, "Ingresa un Nombre, Apellido, o DNI");


            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From RegistrarTecnicos Where Nombres like ('%" + BuscarTecnico.Text + "%') OR Apellidos LIKE ('%" + BuscarTecnico.Text + "%') OR DNI LIKE ('%" + BuscarTecnico.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ListarTecnicosDataGridView.DataSource = dt;
            conexion.Close();
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

        private void ListarTecnicosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = ListarTecnicosDataGridView.Rows[e.RowIndex];

                // Seleccionar la fila completa
                selectedRow.Selected = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ListarTecnicosDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = ListarTecnicosDataGridView.Rows[e.RowIndex];
            string idSolicitante = selectedRow.Cells[0].Value.ToString();
            string fecha = selectedRow.Cells[1].Value.ToString();
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
            this.Close();
            

        }
    }
}
