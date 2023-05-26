using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega.Registrar
{
    public class Registro
    {
        public class RegistrarTecnicos
        {
            public int IDSolicitante { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string Nombres { get; set; }
            public string Apellido { get; set; }
            public string DNI { get; set; }
            public string Direccion { get; set; }
            public string Num_Telefono { get; set; }
            public string Notas { get; set; }
        }

        public class RegistrarBaseForanea
        {
            public int IDSolicitante { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string Nombre { get; set; }
            public string Lugar_Zona { get; set; }
            public string Direccion { get; set; }
            public string Num_Telefono { get; set; }
            public string Notas { get; set; }
        }

        public class RegistrarPuntodeVenta
        {
            public int IDSolicitante { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string Nombre { get; set; }
            public string Lugar_Zona { get; set; }
            public string Direccion { get; set; }
            public string Num_Telefono { get; set; }
            public string Notas { get; set; }
        }
    }
}
