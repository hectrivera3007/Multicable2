using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class BajosMinimos
    {
        public DateTime Fecha { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Medida { get; set; }
        public int Ideal { get; set; }
        public int Diferencia { get; set; }
    }
}
