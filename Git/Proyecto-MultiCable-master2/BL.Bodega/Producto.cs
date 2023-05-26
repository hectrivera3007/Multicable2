using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Producto
    {
        public int ID { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string CodigoProd { get; set; }
        public string Descripcion { get; set; }
        public int BodegaID { get; set; }
        public int Numero_Documento { get; set; }
    }
}
