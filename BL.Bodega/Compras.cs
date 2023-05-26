using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega.Compras
{
    public class Compras
    {
        public int Cantidad { get; set; }
        public string NumOrden { get; set; }
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public float PrecioUnitarioCompraDolares { get; set; }
        public float CostFOBDolares { get; set; }
        public float CostosDeTransporte { get; set; }
        public float CostoCIFDolares { get; set; }
        public float CostoCIFLempiras { get; set; }
        public float CostosDeImportacion { get; set; }
        public float CostoTotalCompraLempiras { get; set; }
        public float CostoTotalCompraDolares { get; set; }
    }
    public class Compras_Encabezado
    {
        public int ID { get; set; }
        public string Proveedor { get; set; }
        public string NumDeclaracion { get; set; }
        public string NumFactura { get; set; }
        public DateTime FechaEnBodega { get; set; }
        public float ImpuestoPagado { get; set; }
    }
}
