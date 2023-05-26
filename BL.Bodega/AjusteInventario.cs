using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class AjusteInventario
    {
        public class AjusteDataGrid
        {
            public int ID { get; set; }
            public int BodegaID { get; set; }
            public int Código { get; set; }
            public string Descripcion { get; set; }
            public int Existencia { get; set; }
            public string Faltante_Sobrante { get; set; }
            public string TipodeAjuste { get; set; }
            public int Cantidad { get; set; }
            public int Cantidad_Ajustada { get; set; }
        }

        public class AjusteDatosGenerales
        {
            public DateTime Fecha { get; set; }
            public string TipodeAjuste { get; set; }
            public string NumdeOrden { get; set; }
            public string Observacion { get; set; }
            public int Bodega { get; set; }
        }
    }
}
