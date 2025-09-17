using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Sql
{
    /// <summary>
    /// Contexto de almacenamiento en base de datos. Aca se definen los nombres de 
    /// las tablas, y los mapeos entre los objetos
    /// </summary>
    public class StoreDbContext : DbContext
    {
        // Se ha eliminado el DbSet de DummyEntity para evitar conflictos de migración
        public DbSet<Automovil> Automoviles { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        protected StoreDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Se ha corregido el nombre de la tabla de "Automovile" a "Automovil"
            modelBuilder.Entity<Automovil>().ToTable("Automovil");

            // Si necesitas usar DummyEntity en el futuro, puedes descomentar esto y el DbSet,
            // pero primero asegúrate de que esa entidad esté bien configurada.
            // modelBuilder.Entity<DummyEntity>().ToTable("DummyEntity");
        }
    }
}