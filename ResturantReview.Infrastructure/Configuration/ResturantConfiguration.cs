using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure.Configuration
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> modelBuilder)
        {
            modelBuilder
                   .HasKey(Restaurant => Restaurant.RestaurantID);

            modelBuilder
                .HasMany(Restaurant => Restaurant.Reviews)
                .WithOne(review => review.Restaurant)
                .HasForeignKey(review => review.RestaurantID);

            


        }
    }
}
