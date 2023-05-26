using BL.Bodega.Compras;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Bodega
{
    public class Contexto : DbContext
    {
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Inventario.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la base de datos despues de eliminarla
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Roles { get; set; }

        //public DbSet<Producto> Producto{ get;set; }
        //public DbSet<Devoluciones> Devoluciones { get; set; }
        //public DbSet<Requisa> Requisa { get; set; }
        //public DbSet<Proveedores> Proveedores { get; set; }
        //public DbSet<AjusteInventario> AjusteInventario { get; set; }
        //public DbSet<InventarioBodegas> InventarioBodegas { get; set; }
        ////public DbSet<ComprobanteEntrega> ComprobanteEntrega { get; set; }
        //public DbSet<Roles> Rol { get; set; }
        //public DbSet<Compras_Encabezado> Compras { get; set; }
        //public DbSet<CostosImp> CostosImp { get; set; }
        //public DbSet<ComprobanteEntrega> ComprobanteEntreg { get; set; }
    }
}
