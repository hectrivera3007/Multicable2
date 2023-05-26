using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class ReporteDetalladoEntradas
    {
        public class Encabezado
        {
            public DateTime RangoFechas { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string NOrden { get; set; }
            public string MovimientoReportado { get; set; }
            public DateTime FechaActual { get; set; }
        }

        public class InfoDataGrid
        {
            public int ID { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string NOrden { get; set; }
            public string Proveedor { get; set; }
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public string Medida { get; set; }
            public string Bodega { get; set; }
            public decimal PrecioCompra { get; set; }
            public decimal PrecioVenta { get; set; }
            public decimal Cantidad { get; set; }
            public decimal SubTotal { get; set; }
        }
    }
}
