using AntonyCelulares.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AntonyCelulares.Data
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        #region Properties
        //public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemEntity> Articulos { get; set; }
        public DbSet<CharacteristicEntity> Caracteristicas { get; set; }

        #endregion
        #region Contructors

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        #endregion

    }
}
