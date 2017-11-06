using CRUD.Models;
using System.Data.Entity;

namespace CRUD.DB
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
