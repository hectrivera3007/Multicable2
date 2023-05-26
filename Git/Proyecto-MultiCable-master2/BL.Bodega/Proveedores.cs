using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string RTN { get; set; }
        public string PersonaContacto { get; set; }
        public string Direccion { get; set; }
        public string Pais_Zona { get; set; }
        public string Tipo_Proveedor { get; set; }
        public string Num_Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Notas { get; set; }
    }
}
