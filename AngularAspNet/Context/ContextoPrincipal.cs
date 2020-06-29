using System.Data.Entity;
using AngularAspNet.Models;

namespace AngularAspNet.Context
{
    public class ContextoPrincipal : DbContext
    { 
        public ContextoPrincipal() : base("MiConexion")
        {

        }

        public virtual DbSet<Usuario> _Usuario { get; set; }
    }

}