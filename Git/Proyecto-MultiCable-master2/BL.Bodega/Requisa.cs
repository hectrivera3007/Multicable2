using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Requisa
    { 
        public class RequisaEntrada { 
            public int RequisaID { get; set; }
            public string NumOrden { get; set; }
            public string Descripcion { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public decimal Subtotal { get; set; }
        }


        public class RequisaSalida
        {
            public int RequisaID { get; set; }
            public string Solicitante { get; set; }
            public DateTime Fecha { get; set; }
            public string Descripcion { get; set; }
            public string Tecnico { get; set; }
        }

    }
}
