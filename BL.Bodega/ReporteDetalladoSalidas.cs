using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class ReporteDetalladoSalidas
    {
        public class EncabezadofrmSalida
        {
            public DateTime RangoFechas { get; set; }
            public string NombreProveedor { get; set; }
            public string MovimientoReportado { get; set; }
        }

        public class InfoDataGridSalida
        {
            public int ID { get; set; }
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public int Cantidad { get; set; }
            public int CostoUnitario { get; set; }
            public int Total { get; set; }
        }

    }
}
