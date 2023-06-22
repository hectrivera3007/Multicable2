using BL.Bodega;
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
using System.Data.Sql;

namespace MultiBodega_v1
{
    public partial class FrmUsuarios : Form
    {
        Usuarios _usuarios;

        static string ConexionString = @"Data Source=(localdb)\CATELSA;Initial Catalog = CATELSA-MULTICABLE; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False";
        SqlConnection conexion = new SqlConnection(ConexionString);
        

        public string _iDTextBox { get; set; }
        public string _rolNameTextBox { get; set; }
        private static int _iDRol = 0;
        private static int _indice = 0;

        public FrmUsuarios()
        {
            InitializeComponent();
            _usuarios = new Usuarios();

        }
        #region "Mis Metodos"

        private void Formato()
        {
            //dGV1.Columns[0].Width = 80;
            //dGV1.Columns[0].HeaderText = "ID";
            //dGV1.Columns[1].Width = 120;
            //dGV1.Columns[1].HeaderText = "Codigo";
            //dGV1.Columns[2].Width = 80;
            //dGV1.Columns[2].HeaderText = "Nombre de Usuario";
            //dGV1.Columns[3].Width = 80;
            //dGV1.Columns[3].HeaderText = "Contraseña";
            //dGV1.Columns[4].Width = 80;
            //dGV1.Columns[4].HeaderText = "Confirmar Contraseña";
            //dGV1.Columns[5].Width = 80;
            //dGV1.Columns[5].HeaderText = "Rol";
            //dGV1.Columns[6].Width = 80;
            //dGV1.Columns[6].HeaderText = "Contraseña";
            //dGV1.Columns[7].Width = 80;
            //dGV1.Columns[7].HeaderText = "Rol";
        }

        private void Listado(string cTexto)
        {
            //UsuariosBD Datos = new UsuariosBD();
            //dGV1.DataSource = Datos.Listado(cTexto);
            //this.Formato();
        }

        private void Estado_TextBox(bool estadoTextBox)
        {
            //nombreTextBox.ReadOnly = !estadoTextBox;
            //confirmarContrasenaTextBox.ReadOnly = !estadoTextBox;
            //nombreUsuarioTextBox.ReadOnly = !estadoTextBox;
            //contrasenaTextBox.ReadOnly = !estadoTextBox;
        }

        #endregion

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Vista_Usuarios' Puede moverla o quitarla según sea necesario.
            this.vista_UsuariosTableAdapter.Fill(this._CATELSA_MULTICABLE.Vista_Usuarios);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter1.Fill(this._CATELSA_MULTICABLE.Usuario);
            string consulta = "SELECT * FROM Vista_Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            Vista_UsuariosDataGridView.DataSource = dt;
        }


        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContUsuarios Volver = new FrmContUsuarios();
            Volver.Show();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * From Vista_Usuarios WHERE Nombre LIKE ('%" +Txtbuscar.Text +"%')";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            Vista_UsuariosDataGridView.DataSource = dt;
            this.vista_UsuariosTableAdapter.Fill(_CATELSA_MULTICABLE.Vista_Usuarios);
            conexion.Close();
        }

        public void Vista_UsuariosDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                //Mostrar el formulario de tu elección
                DataGridViewRow row = Vista_UsuariosDataGridView.CurrentRow;
                ModificarUsuario Mostrar = new ModificarUsuario(); 
                Mostrar.iDTextBox.Text = row.Cells[1].Value.ToString();
                Mostrar.nombreTextBox.Text = row.Cells[2].Value.ToString();
                Mostrar.nombreUsuarioTextBox.Text = row.Cells[3].Value.ToString();
                Mostrar.numTelefonoTextBox.Text = row.Cells[4].Value.ToString();
                Mostrar.contrasenaTextBox.Text= row.Cells[5].Value.ToString();
                Mostrar.confirmarContrasenaTextBox.Text = row.Cells[6].Value.ToString();
                Mostrar.bodegaIDComboBox.Text = row.Cells[7].Value.ToString();
                Mostrar.rolIDComboBox.Text = row.Cells[8].Value.ToString();
                Mostrar.activoCheckBox.Text = row.Cells[9].Value.ToString();
                Mostrar.ShowDialog();
            }
        }

        private void BtnActualizarGrid_Click(object sender, EventArgs e)
        {
            Vista_UsuariosDataGridView.Refresh();
        }
    }
}