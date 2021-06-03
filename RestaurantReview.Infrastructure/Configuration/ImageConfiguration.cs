using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> modelBuilder)
        {
            modelBuilder
                .HasKey(i => i.ImageID);

            modelBuilder
                .HasOne(i => i.Restaurant)
                .WithMany(r => r.Images);

            modelBuilder
                .HasOne(i => i.ApplicationUser)
                .WithMany(u => u.Images);
        }
    }
}
