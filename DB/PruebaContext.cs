using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions<PruebaContext> options): base(options) { 
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Documentos> Documentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>().ToTable("T_AREAS");
            modelBuilder.Entity<Documentos>().ToTable("T_DOCUMENTOS");
        }
    }
}