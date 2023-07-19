using MultiBodega_v1.Configuración;
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
    public partial class FrmRol : Form
    {
        SqlConnection Conexion = new SqlConnection("Server = (localdb)\\CATELSA; database=CATELSA-MULTICABLE; Integrated Security = true;");

        public string _iDTextBox { get; set; }
        public string _rolNameTextBox { get; set; }
        private static int _iDRol = 0;
        private static int _indice = 0;

        public FrmRol()
        {
            InitializeComponent();
        }

        private int ObtenerUltimoIDProducto()
        {
            // Realiza la consulta a la base de datos para obtener el último valor de IDProducto
            // Supongamos que utilizas una conexión a la base de datos llamada "conexion" y una consulta SQL adecuada para tu base de datos específica
            string consulta = "SELECT MAX(RolID) FROM Rol";
            using (SqlCommand comando = new SqlCommand(consulta, Conexion))
            {
                Conexion.Open();
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
            Conexion.Close();
        }

        private void EstablecerValorIDProducto()
        {
            int ultimoIDProducto = ObtenerUltimoIDProducto();
            int siguienteIDProducto = ultimoIDProducto + 1;
            iDTextBox.Text = siguienteIDProducto.ToString();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmContenedorConfig();
            Volver.Show();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLE.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter1.Fill(this._CATELSA_MULTICABLE.Rol);
            EstablecerValorIDProducto();
        }

        private void HabilitarControl(Control control, bool habilitado)
        {
            //control.Enabled = habilitado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rolName = rolNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(rolName))
            {
                MessageBox.Show("Por favor, ingrese un Nombre de Rol válido.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool rolNameExistente = _CATELSA_MULTICABLE.Rol.AsEnumerable().Any(row => row.Field<string>("RolName") == rolName);

            if (rolNameExistente)
            {
                
                MessageBox.Show("El Rol que intenta guardar ya existe. Por favor, ingrese un Nombre de Rol diferente.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea Guardar este registro?",
                                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado==DialogResult.Yes)
            {
                
                
                this.rolTableAdapter1.Guardar(rolNameTextBox.Text, activoCheckBox.Checked);
                this.rolTableAdapter1.Fill(this._CATELSA_MULTICABLE.Rol);

                rolNameTextBox.Clear();
                iDTextBox.Clear();
                activoCheckBox.Checked = false;
                EstablecerValorIDProducto();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            //Le preguntamos al usuario si en verdad quiere eliminar el registro.
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, eliminamos el registro
            if (resultado == DialogResult.Yes)            
            {
                this.rolTableAdapter1.Eliminar(Int32.Parse(iDTextBox.Text)); // Eliminamos el registro
                this.rolTableAdapter1.Fill(_CATELSA_MULTICABLE.Rol); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            rolNameTextBox.Clear();
            iDTextBox.Clear();
            activoCheckBox.Checked = false;
        }

        private void rolDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            // Verificar que el botón presionado sea el correspondiente a la columna de selección
            if (e.ColumnIndex == rolDataGridView.Columns["btnSeleccionar"].Index && e.RowIndex >= 0)
            {
                // Obtener la fila correspondiente
                DataGridViewRow row = rolDataGridView.Rows[e.RowIndex];
                int index = e.RowIndex;

                // Establecer la propiedad Selected de la fila en true
                row.Selected = true;

                //Decirle a los textbox que valores debe tomar cuando se da clic en el boton seleccionar
                _iDTextBox = rolDataGridView.Rows[index].Cells[1].Value.ToString();
                _rolNameTextBox = rolDataGridView.Rows[index].Cells[2].Value.ToString();
                this.DialogResult = DialogResult.OK;
                iDTextBox.Text = _iDTextBox;
                rolNameTextBox.Text = _rolNameTextBox;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            iDTextBox.Clear();
            rolNameTextBox.Clear();
            rolNameTextBox.Focus();
            
        }
        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            this.rolTableAdapter1.Modificar(@rolNameTextBox.Text, @activoCheckBox.Checked, Int32.Parse(@iDTextBox.Text));
            this.rolTableAdapter1.Fill(_CATELSA_MULTICABLE.Rol);
            rolDataGridView.Refresh();
        }

        
    }
}
