using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega.Compras
{
    public class PrecioVenta
    {
        public int ID { get; set; }
        public decimal Costo_Total_Unitario_Dolares { get; set; }
        public decimal Costo_Total_Unitario_LPS { get; set; }
        public decimal Margen_Utilidad { get; set; }
        public decimal PrecioVentaLempiras1 { get; set; }
        public decimal PrecioVentaLempiras2 { get; set; }
        public decimal PrecioVentaLempiras3 { get; set; }
        public decimal PrecioVentaLempiras4 { get; set; }
        public decimal PrecioVentaDolares1 { get; set; }
        public decimal PrecioVentaDolares2 { get; set; }
        public decimal PrecioVentaDolares3 { get; set; }
        public decimal PrecioVentaDolares4 { get; set; }

    }
}
