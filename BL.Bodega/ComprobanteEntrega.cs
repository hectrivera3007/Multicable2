﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class ComprobanteEntrega
    {
        public int ID { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public string unidades { get; set; }
        public float Metros { get; set; }
        public string Observacion { get; set; }
    }
}
