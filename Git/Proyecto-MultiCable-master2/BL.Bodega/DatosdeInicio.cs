using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var Usuario1 = new Usuario
            {
                ID = 1,
                Nombre = "",
                NombreUsuario = "",
                NumTelefono = "",
                Contrasena = "",
                ConfirmarContrasena = "",
                Activo = true
            };

            contexto.Usuario.Add(Usuario1);

            

            base.Seed(contexto);
        }
    }
}
