using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using MultiBodega_v1.Botonera;

namespace MultiBodega_v1
{
    public partial class GenerarCodigodeBarra : Form
    {
        public string cUsuario;
        public GenerarCodigodeBarra()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel1.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128A,textBox1.Text,Color.Black,Color.White,400,100);
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Image imagenfinal = (Image)panel1.BackgroundImage.Clone();
            SaveFileDialog cajaguardar = new SaveFileDialog();
            cajaguardar.AddExtension = true;
            cajaguardar.Filter = "Image PNG(*.png)|*.png";
            cajaguardar.ShowDialog();
            if (!string.IsNullOrEmpty(cajaguardar.FileName))
            {
                imagenfinal.Save(cajaguardar.FileName, ImageFormat.Png);
            }
            imagenfinal.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var ingresarProducto = new FrmIngresarProducto();
            //string selectedItemText = ingresarProducto.SelectedItemText;
            //string textValue = ingresarProducto.TextValue;
            //textBox1.Text = textValue;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new Botonera_APP(cUsuario);
            Volver.Show();
        }
    }
}
