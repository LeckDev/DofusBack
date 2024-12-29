using Leck2.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Leck2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Example> Examples { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<SoldingItem> SoldingItem { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Bundle> Bundle { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurations des relations
            modelBuilder.Entity<Bundle>()
                .HasMany(b => b.Transactions)
                .WithOne(t => t.Bundle)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.SoldingItem)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SoldingItem>()
                .HasOne(si => si.Item)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SoldingItem>()
                .HasMany(si => si.SellingPrices)
                .WithOne(p => p.SellingItem)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SoldingItem>()
                .HasMany(si => si.CostPrices)
                .WithOne(p => p.CostingItem)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Price>()
                .HasOne(p => p.SellingItem)
                .WithMany(si => si.SellingPrices)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Price>()
                .HasOne(p => p.CostingItem)
                .WithMany(si => si.CostPrices)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Bundles)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
