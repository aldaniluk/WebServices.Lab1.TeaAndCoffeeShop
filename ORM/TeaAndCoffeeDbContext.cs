namespace ORM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeaAndCoffeeDbContext : DbContext
    {
        public TeaAndCoffeeDbContext()
            : base("name=TeaAndCoffeeModel")
        {
        }

        public virtual DbSet<Coffee> Coffee { get; set; }
        public virtual DbSet<CoffeeSort> CoffeeSort { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Tea> Tea { get; set; }
        public virtual DbSet<TeaSort> TeaSort { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeeSort>()
                .HasMany(e => e.Coffee)
                .WithRequired(e => e.CoffeeSort)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Coffee)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.MadeFromCountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Tea)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.MadeFromCountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quality>()
                .HasMany(e => e.Coffee)
                .WithRequired(e => e.Quality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quality>()
                .HasMany(e => e.Tea)
                .WithRequired(e => e.Quality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeaSort>()
                .HasMany(e => e.Tea)
                .WithRequired(e => e.TeaSort)
                .WillCascadeOnDelete(false);
        }
    }
}
