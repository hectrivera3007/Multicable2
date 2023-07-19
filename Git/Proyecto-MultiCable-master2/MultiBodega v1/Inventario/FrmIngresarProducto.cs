using BL.Bodega;
using MultiBodega_v1.Botonera;
using MultiBodega_v1.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1
{
    public partial class FrmIngresarProducto : Form
    {

        private DataGridViewRow selectedRow;
        
        //SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");

        public FrmIngresarProducto()
        {
            InitializeComponent();
            productoDataGridView.CellDoubleClick += productoDataGridView_CellContentDoubleClick;

        }

        private void FrmIngresarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this._CATELSA_MULTICABLE.Bodega);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.tipoMaterialTableAdapter.Fill(this._CATELSA_MULTICABLE.TipoMaterial);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);

            EstablecerValorIDProducto();
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
                var Back = new Inventario_Botonera();
                Back.ShowDialog();
            }
        }

        private int ObtenerUltimoIDProducto()
        {
            // Realiza la consulta a la base de datos para obtener el último valor de IDProducto
            // Supongamos que utilizas una conexión a la base de datos llamada "conexion" y una consulta SQL adecuada para tu base de datos específica
            string consulta = "SELECT MAX(IDProducto) FROM Productos";
            
            using (SqlCommand comando = new SqlCommand(consulta, ConexionBD.ObtenerConexion()))
            {

                // Ejecuta la consulta y obtén el resultado
                object resultado = comando.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    // Parsea el resultado a un entero y devuelve el valor
                    return Convert.ToInt32(resultado);
                }
            }

            // Si no se encuentra ningún valor, devuelve 0 o algún valor inicial apropiado
            return 0;
            //Conexion.Close();
        }

        private void EstablecerValorIDProducto()
        {
            int ultimoIDProducto = ObtenerUltimoIDProducto();
            int siguienteIDProducto = ultimoIDProducto + 1;
            iDProductoTextBox.Text = siguienteIDProducto.ToString();
        }

        

        




        //private void BtnGuardar_Click(object sender, EventArgs e)
        //{


        //    string codigo = TxtCodigoGen.Text;
        //    if (string.IsNullOrWhiteSpace(codigo))
        //    {
        //        MessageBox.Show("La casilla para el código del producto no puede estar vacía, ni contener valores duplicados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    DateTime fecha = DtFechaIngreso.Value;

        //    DialogResult opcion = MessageBox.Show("¿Está listo para guardar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (opcion == DialogResult.Yes)
        //    {
        //        this.productosTableAdapter.Guadar_(fecha, CmbNombreTipo.SelectedIndex.ToString() + 1, TxtCodigoGen.Text, TxtDescripcion.Text, bodegaIDComboBox.SelectedIndex, 1, activoCheckBox.Checked);
        //        this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);
        //        EstablecerValorIDProducto();
        //        Limpiar();
        //    }
        //}

        private void Limpiar()
        {
            DtFechaIngreso.Value = DateTime.Now;
            //CmbNombreTipo.SelectedIndex = -1;
            TxtCodigoGen.Clear();
            TxtDescripcion.Clear();
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = true;
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

            string tipoMaterial = NombreTipoComboBox.SelectedItem.ToString(); // Obtén el tipo de material seleccionado

            string codigo = $"{tipoMaterial}-{Codigo}"; // Genera el código utilizando el tipo de material y el código ingresado
                
                
                DialogResult opcion;
            opcion = MessageBox.Show("¿Está listo para guardar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                try
                {
                    this.productosTableAdapter.Guardar(FechaString, NombreTipoComboBox.SelectedIndex.ToString() + 1, TxtCodigoGen.Text,
                    TxtDescripcion.Text, Int32.Parse(bodegaIDComboBox.SelectedIndex.ToString()), activoCheckBox.Checked) ;
                    this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);
                    EstablecerValorIDProducto();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex.ToString());
                }
            }

            //string Codigo = TxtCodigoGen.Text;
            //if (string.IsNullOrWhiteSpace(Codigo))
            //{
            //    MessageBox.Show("La casilla para el código del producto no puede estar vacía," +
            //    "ni contener valores duplicados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //DateTime Fecha = DtFechaIngreso.Value;
            //string FechaString = Fecha.ToString();

            //DialogResult opcion;
            //opcion = MessageBox.Show("¿Está listo para guardar este registro?", "Aviso del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (opcion == DialogResult.Yes)
            //{
            //    try
            //    {
            //        this.productosTableAdapter.Guardar(FechaString, NombreTipoComboBox.SelectedIndex.ToString() + 1, TxtCodigoGen.Text, 
            //        TxtDescripcion.Text, Int32.Parse(bodegaIDComboBox.SelectedIndex.ToString()), activoCheckBox.Checked) ;
            //        this.productosTableAdapter.Fill(this._CATELSA_MULTICABLE.Productos);
            //        EstablecerValorIDProducto();
            //        Limpiar();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(" " + ex.ToString());
            //    }
            //}
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
            //CmbNombreTipo.SelectedValue = -1;
            TxtCodigoGen.Text = " ";
            TxtDescripcion.Clear();
            bodegaIDComboBox.SelectedIndex = -1;
            activoCheckBox.Checked = true;
        }

        //private void productoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 0 && e.RowIndex != -1)
        //    {
        //        iDProductoTextBox.Text = productoDataGridView.SelectedCells[1].Value.ToString();
        //        CmbNombreTipo.Text = productoDataGridView.SelectedCells[2].Value.ToString();
        //        TxtCodigoGen.Text = productoDataGridView.SelectedCells[3].Value.ToString();
        //        DtFechaIngreso.Text = productoDataGridView.SelectedCells[4].Value.ToString();
        //        TxtDescripcion.Text = productoDataGridView.SelectedCells[5].Value.ToString();
        //        bodegaIDComboBox.Text = productoDataGridView.SelectedCells[6].Value.ToString();
        //        activoCheckBox.Text = productoDataGridView.SelectedCells[7].Value.ToString();
        //    }
        //}

        private void productoDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = productoDataGridView.Rows[e.RowIndex];
                string id = selectedRow.Cells[0].Value.ToString();
                string NombreTipo = selectedRow.Cells[1].Value.ToString();
                string CodigoGen = selectedRow.Cells[2].Value.ToString();
                //DateTime FechaIngreso = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                string fechaCelda = selectedRow.Cells[3].Value.ToString();
                DateTime FechaIngreso = DateTime.ParseExact(fechaCelda, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string Descripcion = selectedRow.Cells[4].Value.ToString();
                string Bodega = selectedRow.Cells[5].Value.ToString();
                bool Activo = Convert.ToBoolean(selectedRow.Cells[7].Value);

                // Abrir el formulario de modificación y pasar el registro seleccionado
                ModificarProducto formModificar = new ModificarProducto(id, NombreTipo, CodigoGen, fechaCelda, Descripcion, Bodega, Activo);
                formModificar.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }


        }
    }
}