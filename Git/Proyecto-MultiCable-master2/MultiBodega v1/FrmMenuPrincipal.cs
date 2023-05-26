using MultiBodega_v1.Bodega;
using MultiBodega_v1.Bodegas;
using MultiBodega_v1.Formularios_de_Registro;
using MultiBodega_v1.Inventario;
using MultiBodega_v1.Reporte_Bodegas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiBodega_v1
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Permisos' Puede moverla o quitarla según sea necesario.
            this.permisosTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Permisos);
            var login = new LoginBodega();
            login.ShowDialog();
        }


        private void SalirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var LoginBodega = new LoginBodega();
            LoginBodega.ShowDialog();
        }

        private void CódigoDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var codebar = new GenerarCodigodeBarra
            {
                MdiParent = this
            };
            codebar.Show();
        }

        private void EntradaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var EntradaEq = new FrmAgregarProductoExistente();
            EntradaEq.MdiParent = this;
            EntradaEq.Show();
        }

        private void VerUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Usuario = new FrmUsuarios();
            Usuario.Show();
        }

        private void SalidaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ProductoEx = new FrmIngresarProducto();
            ProductoEx.MdiParent = this;
            ProductoEx.Show();
        }

        private void Bodega2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var SalidaProd = new FrmSalidaProducto();
            //SalidaProd.Show();
        }

        private void ComprobanteDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var requisa = new FrmRequisaEntrada();
            requisa.MdiParent = this;
            requisa.Show();
        }

        private void ReporteBodega1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var requisaSa = new FrmRequisaSalida();
            requisaSa.MdiParent = this;
            requisaSa.Show();
        }

        private void InventarioFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InventarioGeneral = new FrmInventarioGeneral(); 
            InventarioGeneral.MdiParent = this;
            InventarioGeneral.Show();
        }

        private void AjusteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AjusteInv = new Inventario.AjusteInventario();
            AjusteInv.MdiParent = this;
            AjusteInv.Show();
        }

        private void ReporteProductoExistenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var productoExistente= new FrmAgregarProductoExistente();
            productoExistente.MdiParent = this;
            productoExistente.Show();
        }

        private void RegistrarNuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoProveedor = new FrmRegistrarProveedores();
            NuevoProveedor.MdiParent = this;
            NuevoProveedor.Show();
        }

        private void InventarioporBodega_Bodega1_Click(object sender, EventArgs e)
        {
            var Bodega1_Inv = new Bodega1();
            Bodega1_Inv.MdiParent = this;
            Bodega1_Inv.Show();
        }

        private void InventarioporBodega_Bodega2_Click(object sender, EventArgs e)
        {
            var Bodega2_Inv = new Bodega2();
            Bodega2_Inv.MdiParent = this;
            Bodega2_Inv.Show();
        }

        private void InventarioporBodega_Bodega3_Click(object sender, EventArgs e)
        {
            var Bodega3_Inv = new Bodega3();
            Bodega3_Inv.MdiParent = this;
            Bodega3_Inv.Show();
        }

        private void InventarioporBodega_Bodega4_Click(object sender, EventArgs e)
        {
            var Bodega4_Inv = new Bodega4();
            Bodega4_Inv.MdiParent = this;
            Bodega4_Inv.Show();
        }

        private void InventarioBodega_1_Click(object sender, EventArgs e)
        {
            var Bodega_1_INV = new Bodega.Bodega_1();
            Bodega_1_INV.MdiParent = this;
            Bodega_1_INV.Show();
        }

        private void InventarioBodega_2_Click(object sender, EventArgs e)
        {
            var Bodega_2_INV = new Bodega.Bodega_2();
            Bodega_2_INV.MdiParent = this;
            Bodega_2_INV.Show();
        }

        private void InventarioBodega_3_Click(object sender, EventArgs e)
        {
            var Bodega_3_INV = new Bodega.Bodega_3();
            Bodega_3_INV.MdiParent = this;
            Bodega_3_INV.Show();
        }

        private void InventarioBodega_4_Click(object sender, EventArgs e)
        {
            var Bodega_4_INV = new Bodega.Bodega_4();
            Bodega_4_INV.MdiParent = this;
            Bodega_4_INV.Show();
        }

        private void ReporteDetalladoDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ReporteDet_Entradas = new FrmReporteDetalladoEntradas();
            ReporteDet_Entradas.MdiParent = this;
            ReporteDet_Entradas.Show();
        }

        private void ReporteDetalladoDeSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ReporteDet_Salidas = new FrmReporteDetalladoSalidas();
            ReporteDet_Salidas.MdiParent = this;
            ReporteDet_Salidas.Show();
        }

        private void DevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevaDevolucion = new FrmDevoluciones();
            NuevaDevolucion.MdiParent = this;
            NuevaDevolucion.Show();
        }

        private void BajosMínimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Bajo_Min = new FrmBajosMinimos();
            Bajo_Min.MdiParent = this;
            Bajo_Min.Show();
        }

        private void RegistrarNuevoTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoTecnico = new FrmRegistrarTecnico();
            NuevoTecnico.MdiParent = this;
            NuevoTecnico.Show();
        }

        private void ListarProveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var ListaProveedores = new FrmListarProveedor();
            ListaProveedores.MdiParent = this;
            ListaProveedores.Show();
        }

        private void ListarTécnicosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var ListarNuevoTecnico = new FrmListarTecnicos();
            ListarNuevoTecnico.MdiParent = this;
            ListarNuevoTecnico.Show();
        }

        private void ListarBasesForáneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListarBaseForanea = new FrmListarBaseForanea();
            ListarBaseForanea.MdiParent = this;
            ListarBaseForanea.Show();
        }

        private void ListarNuevoPuntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListarPuntodeVenta = new FrmListarPuntodeVenta();
            ListarPuntodeVenta.MdiParent = this;
            ListarPuntodeVenta.Show();
        }

        private void RegistrarNuevaBaseForáneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistrarBaseForanea = new FrmRegistrarBaseForanea();
            RegistrarBaseForanea.MdiParent = this;
            RegistrarBaseForanea.Show();
        }

        private void RegistrarNuevoPuntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistrarPuntodeVenta = new FrmRegistrarPuntodeVenta()
            {
                MdiParent = this
            };
            RegistrarPuntodeVenta.Show();
        }

        private void RegistrarNuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Compra = new Compras.FrmCompras()
            {
                MdiParent = this
            };
            Compra.Show();
        }

        private void BuscarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BuscaEntrada = new Requisas.FrmBuscarEntrada()
            {
                MdiParent = this
            };            
            BuscaEntrada.Show();
        }

        private void BuscarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BuscaSalida = new Requisas.FrmBuscarSalida()
            {
                MdiParent = this
            };
            BuscaSalida.Show();
        }
    }
}
