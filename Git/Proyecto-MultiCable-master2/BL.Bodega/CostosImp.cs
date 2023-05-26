using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega.Compras
{
    public class CostosImp
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public int NumOrden { get; set; }
        public decimal Flete { get; set; }
        public decimal Importacion { get; set; }
        public decimal Flete_Seguro_ComisionBancaria { get; set; }
        public decimal GastosImportacion { get; set; }
        public decimal FactorCambiario { get; set; }
        public decimal Total { get; set; }

    }
}
