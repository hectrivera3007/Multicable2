using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Devoluciones
    {
        public class DevolucionesInfo
        {
            public int ID { get; set; }
            public int Num_Orden { get; set; }
            public DateTime Fecha { get; set; }
            public int Numero_Referencia { get; set; }
            public string Devuelto_por { get; set; }
            public string Notas { get; set; }
        }

        public class DevolucionesDataGrid
        {
            public int ID { get; set; }
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public int Medida { get; set; }
            public int Entregado { get; set; }
            public int Devuelto { get; set; }
        }
    }
}
