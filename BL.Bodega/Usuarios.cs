using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Bodega.Usuario;

namespace BL.Bodega
{
    public class Usuarios
    {
        Contexto _contexto;
       
        public BindingList<Usuario> ListaUsuario { get; set; }
        
        public Usuarios()
        {
            _contexto = new Contexto();
            ListaUsuario = new BindingList<Usuario>();            
        }
       
        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuario.Load();
            ListaUsuario = _contexto.Usuario.Local.ToBindingList();
            return ListaUsuario;
        }

        public void AgregarUsuario()
        {
            Usuario nuevoUsuario = new Usuario();
            ListaUsuario.Add(nuevoUsuario);
        }
        
        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exito == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exito = true;
            return resultado;
        }

        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exito = true;
            if (usuario==null)
            {
                resultado.Mensaje = "Por favor agregue un usuario";
                resultado.Exito = false;
                return resultado;
            }
            if (string.IsNullOrEmpty(usuario.Nombre) == false)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exito = false;
                return resultado;
            }
            if (usuario.ConfirmarContrasena != usuario.Contrasena)
            {
                resultado.Mensaje = "Las contraseña no coincide, escribala de nuevo";
                resultado.Exito = false;
                return resultado;
            }
            return resultado;
        }

        }
    public class Usuario
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string NumTelefono { get; set; }
        public string Contrasena { get; set; }
        public string ConfirmarContrasena { get; set; }
        public int RolID { get; set; }
        public bool Activo { get; set; }


        public class Resultado
        {
            public bool Exito { get; set; }
            public string Mensaje { get; set; }
        }

        public Usuario()
        {
            Activo = true;
        }
    }

    
}
