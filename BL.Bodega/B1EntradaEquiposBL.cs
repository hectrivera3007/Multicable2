using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class B1EntradaEquiposBL
    {
        public BindingList<EntradaEquipo> EntradaEquipo { get; set; }
        

       
    }
    public class EntradaEquipo
    {
        public int Id { get; set; }
        public double CodigoProd { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string MacID { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }

    }
}
