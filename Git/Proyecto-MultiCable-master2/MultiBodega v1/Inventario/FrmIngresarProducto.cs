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

namespace MultiBodega_v1
{
    public partial class FrmIngresarProducto : Form
    {

        public FrmIngresarProducto()
        {
            InitializeComponent();
        }

        private void FrmIngresarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.tipoMaterialTableAdapter.Fill(this._CATELSA_MULTICABLE.TipoMaterial);

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
            string Codigo = TxtCodigoGen.Text;
            if (string.IsNullOrWhiteSpace(Codigo))
            {
                MessageBox.Show("La casilla para el código del producto no puede estar vacía," +
                "ni contener valores duplicados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DateTime Fecha = DtFechaIngreso.Value;
            string FechaString = Fecha.ToString();
            DialogResult opcion;
            opcion = MessageBox.Show("¿Está listo para guardar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                this.productosTableAdapter.Guardar(DtFechaIngreso.Value.ToString(),CmbNombreTipo.SelectedValue.ToString(),TxtCodigoGen.Text,TxtDescripcion.Text,
                bodegaIDComboBox.SelectedIndex,activoCheckBox.Checked);
                this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);
                DtFechaIngreso.Value=DateTime.Now;
                CmbNombreTipo.SelectedValue = -1;
                TxtCodigoGen.Clear();
                TxtDescripcion.Clear();
                bodegaIDComboBox.SelectedIndex = -1;
                activoCheckBox.Checked = true;
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Limpiando los Textbox
            DtFechaIngreso.Value = DateTime.Now;
            CmbNombreTipo.SelectedValue = -1;
            TxtCodigoGen.Text = " ";
            TxtDescripcion.Clear();
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = true;
        }
    }
}