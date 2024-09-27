using Microsoft.EntityFrameworkCore;
using MyCVCSharp.Models;

namespace MyCVCSharp.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {
        }

        
        public DbSet<GalleryModel> GalleryItems { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<GalleryModel>().HasKey(g => g.Id);

        }

        public override int SaveChanges()
        {  
            return base.SaveChanges();
        }
    }
}