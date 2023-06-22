using MultiBodega_v1.Botonera.Requisas;
using MultiBodega_v1.Compras;
using MultiBodega_v1.Configuración;
using MultiBodega_v1.Registro;
using MultiBodega_v1.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiBodega_v1.Botonera
{
    public partial class Botonera_APP : Form
    {
        
        public Botonera_APP()
        {
            InitializeComponent();
            this.DragEnter += Botonera_APP_DragEnter;
        }
        private void Botonera_APP_DragEnter(object sender, DragEventArgs e)
        {
            // Cancelar el arrastre y soltar estableciendo el efecto en None 
            e.Effect = DragDropEffects.None;
        }

        public void Btn_Inventario_Click(object sender, EventArgs e)
        {
            this.Close();
            var Inventario = new Inventario_Botonera();
            Inventario.ShowDialog();
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            //Oculta el formulario que contiene las opciones de inventario por bodega
            this.Close();
            //Nueva instancia de inventario individual
            var bodega = new FrmBodegaBotonera();
            bodega.ShowDialog(); 
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
            this.Close();
            Botonera_Requisas NuevaRquisa = new Botonera_Requisas();
            NuevaRquisa.ShowDialog();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmContCompras nuevoComp = new FrmContCompras();
            nuevoComp.ShowDialog();
        }

        private void BtnCodigoBarra_Click(object sender, EventArgs e)
        {
            this.Close();
            GenerarCodigodeBarra Nuevo = new GenerarCodigodeBarra();
            Nuevo.ShowDialog();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoConfig = new FrmContenedorConfig();
            nuevoConfig.ShowDialog();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmRegistrar nuevoformregistrar = new FrmRegistrar();
            nuevoformregistrar.ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoCont = new FrmContUsuarios();
            nuevoCont.ShowDialog();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            var nuevoRep = new FrmContReportes();
            nuevoRep.ShowDialog();
        }
    }
}