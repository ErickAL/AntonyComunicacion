using AntonyCelulares.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AntonyCelulares.Data
{
    public class DataContext : DbContext
    {
        #region Properties
        public DbSet<UserEntity> Usuarios { get; set; }
        public DbSet<ItemEntity> Articulos { get; set; }
        public DbSet<CharacteristicEntity> Caracteristicas { get; set; }

        #endregion
        #region Contructors

       
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                   => options.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = AnthonyDB; Trusted_Connection = True; MultipleActiveResultSets = true");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CharacteristicEntity>()
                .HasMany(c => c.Articulos);
            modelBuilder.Entity<ItemEntity>()
                .HasMany(i => i.Caracteristicas);
                
        }
    }
}
