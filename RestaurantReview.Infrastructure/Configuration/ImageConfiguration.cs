using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
