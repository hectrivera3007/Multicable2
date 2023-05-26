using EllipticCurve.Utils;
using iText.Layout.Properties;
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
    public partial class FrmBodegaBotonera : Form
    {
        public FrmBodegaBotonera()
        {
            InitializeComponent();
        }

        private void Bodega1_Click(object sender, EventArgs e)
        {
            this.Close();
            var Bodega_1_INV = new Bodega.Bodega_1();
            Bodega_1_INV.Show();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Botonera_APP Nuevo = new Botonera_APP();
            Nuevo.Show();
        }

        private void Bodega2_Click(object sender, EventArgs e)
        {
            this.Close();
            var Bodega_2_INV = new Bodega.Bodega_2();
            Bodega_2_INV.Show();
        }

        private void Bodega3_Click(object sender, EventArgs e)
        {
            this.Close();
            var Bodega_3_INV = new Bodega.Bodega_3();
            Bodega_3_INV.Show();
        }

        private void Bodega4_Click(object sender, EventArgs e)
        {
            this.Close();
            var Bodega_4_INV = new Bodega.Bodega_4();
            Bodega_4_INV.Show();
        }

        //private void FrmBodegaBotonera_Load(object sender, EventArgs e)
        //{
        //    // Crear un objeto GraphicsPath que define la forma redondeada del formulario
        //    var path = new System.Drawing.Drawing2D.GraphicsPath();
        //    path.StartFigure();
        //    path.AddArc(new Rectangle(0, 0, 80, 80), 180, 90);
        //    path.AddLine(80, 0, this.Width - 80, 0);
        //    path.AddArc(new Rectangle(this.Width - 80, 0, 80, 80), -90, 90);
        //    path.AddLine(this.Width, 80, this.Width, this.Height - 80);
        //    path.AddArc(new Rectangle(this.Width - 80, this.Height - 80, 80, 80), 0, 90);
        //    path.AddLine(this.Width - 80, this.Height, 80, this.Height);
        //    path.AddArc(new Rectangle(0, this.Height - 80, 80, 80), 90, 90);
        //    path.CloseFigure();

        //    // Establecer la región del formulario a la forma redondeada
        //    this.Region = new System.Drawing.Region(path);
        //}
    }
}
