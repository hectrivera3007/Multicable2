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


namespace MultiBodega_v1.Inventario
{
    public partial class FrmListarProveedor : Form
    {

        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-KKJ19FD\SQLEXPRESS;Initial Catalog=CATELSA-MULTICABLE;Integrated Security=True");
        public FrmListarProveedor()
        {
            InitializeComponent();
        }

        private void FrmListarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Proveedores1' Puede moverla o quitarla según sea necesario.
            //this.proveedores1TableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Proveedores1);

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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(BuscarProveedor, "Ingrese el nombre de un proveedor");


            conexion.Open();
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Proveedores Where NombreProveedor like ('%" + BuscarProveedor.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            proveedoresDataGridView.DataSource = dt;
            proveedoresDataGridView.Rows[0].DefaultCellStyle.BackColor = Color.CadetBlue;
            proveedoresDataGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
            conexion.Close();
        }
    }
}