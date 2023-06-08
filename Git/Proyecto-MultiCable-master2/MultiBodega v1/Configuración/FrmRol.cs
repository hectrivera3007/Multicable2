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
        public string _iDTextBox { get; set; }
        public string _rolNameTextBox { get; set; }
        private static int _iDRol = 0;
        private static int _indice = 0;

        public FrmRol()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            var Volver = new FrmContenedorConfig();
            Volver.Show();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_CATELSA_MULTICABLE.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Rol);
        }

        private void rolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_CATELSA_MULTICABLE);

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

            bool rolNameExistente = bD_CATELSA_MULTICABLE.Rol.AsEnumerable().Any(row => row.Field<string>("RolName") == rolName);

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
                
                
                this.rolTableAdapter.Guardar(rolNameTextBox.Text, activoCheckBox.Checked);
                this.rolTableAdapter.Fill(this.bD_CATELSA_MULTICABLE.Rol);
                rolNameTextBox.Clear();
                iDTextBox.Clear();
                activoCheckBox.Checked = false;
                
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
                this.rolTableAdapter.Eliminar(Int32.Parse(iDTextBox.Text)); // Eliminamos el registro
                this.rolTableAdapter.Fill(bD_CATELSA_MULTICABLE.Rol); // Cargamos nuevamente los datos del dataset
            }
            //Limpiamos los TextBox luego de guardar el registro de Rol de Usuario.            
            rolNameTextBox.Clear();
            iDTextBox.Clear();
            activoCheckBox.Checked = false;
        }

        private void rolDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Crear una columna DataGridViewImageColumn para el botón de modificación
            //DataGridViewImageColumn column = new DataGridViewImageColumn();
            //column.HeaderText = "";

            // Puedes dejar el encabezado vacío o establecer un texto personalizado
            //column.Name = "btnSeleccionar"; column.ImageLayout = DataGridViewImageCellLayout.Zoom; 

            // Asegurarse de que la columna se ajuste automáticamente al contenido
             //rolDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

            // Asignar una imagen al botón en cada celda de la columna
                foreach (DataGridViewRow row in rolDataGridView.Rows)
                {
                //Obtener la celda del botón de modificación en cada fila
                DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();

                //Establecer la imagen del botón
                ButtonCell.Value = Properties.Resources.Verificar_; 
                }


            rolDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // para selección de filas
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (rolDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _iDTextBox = rolDataGridView.Rows[index].Cells[1].Value.ToString();
                    _rolNameTextBox = rolDataGridView.Rows[index].Cells[2].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    iDTextBox.Text = _iDTextBox;
                    rolNameTextBox.Text = _rolNameTextBox;
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            iDTextBox.Clear();
            rolNameTextBox.Clear();
            rolNameTextBox.Focus();
            //this.rolTableAdapter.ObtenerIndice();
            //this.rolTableAdapter.Fill(bD_CATELSA_MULTICABLE.Rol);

            // Habilita el botones y textbox
            //HabilitarControl(iDTextBox, true);
            //HabilitarControl(rolNameTextBox, true);
            //HabilitarControl(activoCheckBox, true);
            //HabilitarControl(btnEliminar, true);
            //HabilitarControl(btnGuardar, true);
        }
        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            this.rolTableAdapter.Modificar(@rolNameTextBox.Text,@activoCheckBox.Checked, Int32.Parse(@iDTextBox.Text));
            this.rolTableAdapter.Fill(bD_CATELSA_MULTICABLE.Rol);
            rolDataGridView.Refresh();
        }

        private void rolDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }
    }
}
