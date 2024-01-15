using Microsoft.EntityFrameworkCore;
using Forge.Model;

namespace Forge.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<UserLibrary> UserLibrary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Purchase>().HasOne(p => p.Game).WithMany(p => p.Purchases).HasForeignKey(p => p.GameID);

            modelBuilder.Entity<Purchase>().HasOne(p => p.User).WithMany(p => p.Purchases).HasForeignKey(p => p.UserID);

            modelBuilder.Entity<UserLibrary>().HasOne(p => p.User).WithMany(p => p.UserLibraries).HasForeignKey(p => p.UserID);

            modelBuilder.Entity<UserLibrary>().HasKey(ul => new { ul.LibraryID, ul.GameID, ul.UserID, ul.PurchaseID });

            base.OnModelCreating(modelBuilder);
        }
    }
}
