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
using MySql.Data;
using MySql.Data.MySqlClient;
using MultiBodega_v1;
using MultiBodega_v1.Botonera;

namespace MultiBodega_v1
{
    public partial class LoginBodega : Form
    {
        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");
        public static string cUsuario;
       

        public LoginBodega()
        {
            InitializeComponent();
            
        }

        private void LoginBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._CATELSA_MULTICABLE.Usuario);

        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NuevoUsuario = new NuevoUsuario();
            NuevoUsuario.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Passwd.PasswordChar = '\0';
                //Passwd.UseSystemPasswordChar = false;
                checkBox1.Image = Properties.Resources.esconder;
            }
            else
            {
                Passwd.PasswordChar = '●';
                //Passwd.UseSystemPasswordChar = true;
                checkBox1.Image = Properties.Resources.mostrar;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Login()
        {
            Conexion.Open();
            string Consulta = "Select * From Usuario Where NombreUsuario = '" + NombreUsuario.Text + "'and Contrasena='" + Passwd.Text + "'";
            SqlCommand comando = new SqlCommand(Consulta, Conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                var MostrarPantalla = new Botonera_APP(cUsuario);

                this.Hide();
                UsuarioActual.NombreUsuario = NombreUsuario.Text;
                
                MessageBox.Show("¡Bienvenido a CATELSA LOGISTIC!", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMenuPrincipal.Instance.RotuloUser.Text = UsuarioActual.NombreUsuario;

                MostrarPantalla.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
            Conexion.Close();
        }

            public void BtnLogIn_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void Passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(NombreUsuario.Text))
            {
                BtnLogIn.PerformClick();

            }
        }

        private void NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(NombreUsuario.Text))
            {
                NombreUsuario.Focus();

            }
        }
    }
}
