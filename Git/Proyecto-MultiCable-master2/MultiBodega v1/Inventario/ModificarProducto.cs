using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiBodega_v1.Inventario
{
    public partial class ModificarProducto : Form
    {
        private string id;
        private string NombreTipo;
        private string CodigoGen;
        private DateTime FechaIngreso; // Cambiar el tipo de datos a DateTime
        private string Descripcion;
        private string Bodega;
        private bool Activo;

        public ModificarProducto(string id, string NombreTipo, string CodigoGen, string FechaIngreso, string Descripcion, string Bodega, bool Activo)
        {
            InitializeComponent();

            this.id = id;
            this.NombreTipo = NombreTipo;
            this.CodigoGen = CodigoGen;
            this.FechaIngreso = DateTime.Parse(FechaIngreso); // Convertir el string a DateTime
            this.Descripcion = Descripcion;
            this.Bodega = Bodega;
            this.Activo = Activo;

            iDProducto.Text = id;
            CmbNombreTipo.Text = NombreTipo;
            TxtCodigoGen.Text = CodigoGen;
            DtFechaIngreso.Value = this.FechaIngreso; // Asignar el valor de DateTime
            TxtDescripcion.Text = Descripcion;
            bodegaIDComboBox.Text = Bodega;
            activoCheckBox.Checked = Activo;
        }
    }

}
