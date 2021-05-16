using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }



        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
