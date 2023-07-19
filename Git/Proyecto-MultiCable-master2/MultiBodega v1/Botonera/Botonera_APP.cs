using BL.Bodega;
using MultiBodega_v1.Botonera.Requisas;
using MultiBodega_v1.Compras;
using MultiBodega_v1.Configuración;
using MultiBodega_v1.Registro;
using MultiBodega_v1.Reportes;
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


namespace MultiBodega_v1.Botonera
{
    

    public partial class Botonera_APP : Form
    {

        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");
        private int Ypos=0;
        private int Xpos=0;
        public Botonera_APP(string cUsuario)
        {
            InitializeComponent();
        }

        private void Botonera_APP_Load(object sender, EventArgs e)
        {
            
            CenterToScreen();
            Ypos = Location.Y;
            Xpos = Location.X;

        }

        public void Btn_Inventario_Click(object sender, EventArgs e)
        {
            this.Close();
            var Inventario = new Inventario_Botonera();
            Inventario.Show();
            
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            this.Close();
            //Nueva instancia de inventario individual
            var bodega = new FrmBodegaBotonera();
            bodega.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Cerrar Sesión en CATELSA LOGISTIC?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                this.Hide();
                FrmMenuPrincipal.Instance.RotuloUser.Text = " ";
                this.Close();
                LoginBodega login= new LoginBodega();
                login.ShowDialog();

            }
        }

        private void BtnRequisas_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_Requisas NuevaRquisa = new Botonera_Requisas();
            NuevaRquisa.Show();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContCompras nuevoComp = new FrmContCompras();
            nuevoComp.Show();
        }

        private void BtnCodigoBarra_Click(object sender, EventArgs e)
        {
            this.Close();
            GenerarCodigodeBarra Nuevo = new GenerarCodigodeBarra();
            Nuevo.Show();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoConfig = new FrmContenedorConfig();
            nuevoConfig.Show();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar nuevoformregistrar = new FrmRegistrar();
            nuevoformregistrar.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoCont = new FrmContUsuarios();
            nuevoCont.Show();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoRep = new FrmContReportes();
            nuevoRep.Show();
        }
        private void Botonera_APP_Move(object sender, EventArgs e)
        {
            if (Xpos > 0)
            {
                Location = new Point(Xpos, Ypos);

            }
        }
    }
}

//Variables Globales que captura el nombre de usuario
//public static class Nombre 
//{
//    Aquí se crean las variables globales que se pueden usar en cualquier parte del sistema
//    Ejemplo de Variable publica:
//                                "public static string NombreUsuario { get; set; }"
//}