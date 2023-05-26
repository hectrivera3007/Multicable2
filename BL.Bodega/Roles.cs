using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Roles
    {
        Contexto _contexto;
        public BindingList<Rol> ListaRoles { get; set; }

        public Roles()
        {
            _contexto = new Contexto();
            ListaRoles = new BindingList<Rol>();
        }

        public BindingList<Rol> ObtenerRoles()
        {
            _contexto.Roles.Load();
            ListaRoles = _contexto.Roles.Local.ToBindingList();
            return ListaRoles;
        }
    }

    public class Rol
    {
        public int ID { get; set; }
        public string RolName { get; set; }
    }

}
