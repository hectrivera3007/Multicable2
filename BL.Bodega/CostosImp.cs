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
        public float Flete { get; set; }
        public float Importacion { get; set; }
        public float Flete_Seguro_ComisionBancaria { get; set; }
        public float GastosImportacion { get; set; }
        public float FactorCambiario { get; set; }
        public float Total { get; set; }

    }
}
