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
    public partial class FrmListarTecnicos : Form
    {

        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-KKJ19FD\SQLEXPRESS;Initial Catalog=CATELSA-MULTICABLE;Integrated Security=True");
        public FrmListarTecnicos()
        {
            InitializeComponent();
        }

        

        private void FrmListarTecnicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLE.RegistrarTecnicos);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.RegistrarTecnicos' Puede moverla o quitarla según sea necesario.
            //this.registrarTecnicosTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.RegistrarTecnicos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(BuscarTecnico, "Puede buscar por Nombre, Apellido, o DNI");


            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From RegistrarTecnicos Where Nombres like ('%" + BuscarTecnico.Text + "%') OR Apellidos LIKE ('%" + BuscarTecnico.Text + "%') OR DNI LIKE ('%" + BuscarTecnico.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            registro_RegistrarTecnicosDataGridView.DataSource = dt;
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
    }
}
