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
        public float Costo_Total_Unitario_Dolares { get; set; }
        public float Costo_Total_Unitario_LPS { get; set; }
        public float Margen_Utilidad { get; set; }
        public float PrecioVentaLempiras1 { get; set; }
        public float PrecioVentaLempiras2 { get; set; }
        public float PrecioVentaLempiras3 { get; set; }
        public float PrecioVentaLempiras4 { get; set; }
        public float PrecioVentaDolares1 { get; set; }
        public float PrecioVentaDolares2 { get; set; }
        public float PrecioVentaDolares3 { get; set; }
        public float PrecioVentaDolares4 { get; set; }

    }
}
