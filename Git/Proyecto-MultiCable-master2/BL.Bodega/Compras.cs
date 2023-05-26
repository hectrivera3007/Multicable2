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
        public decimal PrecioUnitarioCompraDolares { get; set; }
        public decimal CostFOBDolares { get; set; }
        public decimal CostosDeTransporte { get; set; }
        public decimal CostoCIFDolares { get; set; }
        public decimal CostoCIFLempiras { get; set; }
        public decimal CostosDeImportacion { get; set; }
        public decimal CostoTotalCompraLempiras { get; set; }
        public decimal CostoTotalCompraDolares { get; set; }
    }
    public class Compras_Encabezado
    {
        public int ID { get; set; }
        public string Proveedor { get; set; }
        public string NumDeclaracion { get; set; }
        public string NumFactura { get; set; }
        public DateTime FechaEnBodega { get; set; }
        public decimal ImpuestoPagado { get; set; }
    }
}
