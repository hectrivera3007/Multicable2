using MultiBodega_v1.Configuración;
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
    public partial class FrmRol : Form
    {
        public string _iDTextBox { get; set; }
        public string _rolNameTextBox { get; set; }


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
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
            // TODO: esta línea de código carga datos en la tabla '_CATELSA_MULTICABLEDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);

        }

        private void rolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CATELSA_MULTICABLEDataSet);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.rolTableAdapter.Guardar_Agregar(rolNameTextBox.Text);
            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.rolTableAdapter.Eliminar(Int32.Parse(iDTextBox.Text));

            this.rolTableAdapter.Fill(this._CATELSA_MULTICABLEDataSet.Rol);
        }

        private void rolDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (rolDataGridView.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _iDTextBox = rolDataGridView.Rows[index].Cells["ID"].Value.ToString();
                    _rolNameTextBox = rolDataGridView.Rows[index].Cells["NombreRol"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    iDTextBox.Text = _iDTextBox;
                    rolNameTextBox.Text = _rolNameTextBox;
                    //this.Close();
                }
            }
        }
    }
}
