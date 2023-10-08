using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace PDex.Infrastructure.Persistence
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext() : base() { }
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options) { }

        public DbSet<Domain.Entities.Pokemon> Pokemons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PDexDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Domain.Entities.Pokemon>()
                .OwnsOne(c => c.Name);
            modelBuilder.Entity<Domain.Entities.Pokemon>()
                .OwnsOne(c => c.Stats);
            modelBuilder
                .Entity<Domain.Entities.Pokemon>()
                .Property(c => c.Type)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<string[]>(v));
        }
    }
}
