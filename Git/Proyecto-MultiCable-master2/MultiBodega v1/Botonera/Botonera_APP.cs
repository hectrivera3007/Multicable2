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

        public Botonera_APP()
        {
            InitializeComponent();
        }

        public void Btn_Inventario_Click(object sender, EventArgs e)
        {
            var Inventario = new Inventario_Botonera();
            Inventario.Show();
            this.Close();
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            //Nueva instancia de inventario individual
            var bodega = new FrmBodegaBotonera();
            bodega.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Cerrar CATELSA LOGISTIC?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnRequisas_Click(object sender, EventArgs e)
        {
            Botonera_Requisas NuevaRquisa = new Botonera_Requisas();
            NuevaRquisa.Show();
            this.Close();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            FrmContCompras nuevoComp = new FrmContCompras();
            nuevoComp.Show();
            this.Close();
        }

        private void BtnCodigoBarra_Click(object sender, EventArgs e)
        {
            GenerarCodigodeBarra Nuevo = new GenerarCodigodeBarra();
            Nuevo.Show();
            this.Close();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            var nuevoConfig = new FrmContenedorConfig();
            nuevoConfig.Show();
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar nuevoformregistrar = new FrmRegistrar();
            nuevoformregistrar.Show();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            var nuevoCont = new FrmContUsuarios();
            nuevoCont.Show();
            this.Close();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        { 
            var nuevoRep = new FrmContReportes();
            nuevoRep.Show();
            this.Close();
        }

        private void RelojSistema_Tick(object sender, EventArgs e)
        {
            Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}