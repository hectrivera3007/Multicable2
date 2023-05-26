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
    public partial class FrmIngresarProducto : Form
    {

        public FrmIngresarProducto()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var codigobarra = new GenerarCodigodeBarra();
            codigobarra.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //MOSTRAR MODAL DE CONFIRMACIÓN DE CREAR NUEVO REGISTRO

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MOSTRAR MODAL DE CONFIRMACION DE GUARDAR REGISTRO
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //MOSTRAR MODAL DE ADVERTENCIA DE ELIMINACIÓN DE REGISTRO
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Estás seguro de volver a la vista anterior?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
            //this.Hide();
            //var Back = new Botonera.Inventario_Botonera();
            //Back.Close();
            //Back.ShowDialog(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Está listo para guardar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea Modificar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                
            }
        }
    }
}
