using AntonyCelulares.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AntonyCelulares.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Caracteristica> Caracteristicas { get; set; }

        #endregion

    }
}
