using Microsoft.EntityFrameworkCore;

namespace DTO_Model.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> categories { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Breed> breeds { get; set; }
        public DbSet<Pet> pet { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Breed>().HasOne(a => a.category).WithMany(b => b.breed).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pet>().HasOne(a => a.category).WithMany(b => b.pet).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pet>().HasOne(a => a.breed).WithMany(b => b.pet).HasForeignKey(c => c.BreedId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pet>().HasOne(a => a.location).WithMany(b => b.pet).HasForeignKey(c => c.LocationId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
