using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {

            modelBuilder
                .HasKey(category => category.CategoryID);




            modelBuilder
                .HasMany(category => category.Restaurants)
                .WithMany(resturant => resturant.Categories);










        }
    }
}
