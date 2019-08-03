using EasyFood.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EasyFood.DAL
{
    public class EasyFoodContext : DbContext
    {
        public EasyFoodContext() : base("EasyFoodContext")
        {

        }

        public DbSet<Reteta> Retete { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Bucatar> Bucatari { get; set; }
        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<Card> Carduri { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<Ingredient> Ingrediente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reteta>().ToTable("Retete");
            modelBuilder.Entity<Bucatar>().ToTable("Bucatari");
            modelBuilder.Entity<Produs>().ToTable("Produse");
            modelBuilder.Entity<Angajat>().ToTable("Angajati");
            modelBuilder.Entity<Administrator>().ToTable("Administratori");
            modelBuilder.Entity<Card>().ToTable("Carduri");
            modelBuilder.Entity<Client>().ToTable("Clienti");
            modelBuilder.Entity<Comanda>().ToTable("Comenzi");
            modelBuilder.Entity<Ingredient>().ToTable("Ingrediente");

            //fluent API
            modelBuilder.Entity<Comanda>()
               .HasMany(c => c.Retete).WithMany(i => i.Comenzi)
               .Map(t => t.MapLeftKey("ComandaID")
                          .MapRightKey("RetetaID")
                          .ToTable("ComandaReteta"));
        }

    }
}