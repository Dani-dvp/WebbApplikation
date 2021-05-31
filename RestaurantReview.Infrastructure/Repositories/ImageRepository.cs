
using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        protected new readonly MyDbContext _myDbContext;
        public ImageRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Image Add(Image image)
        {
             _myDbContext.Images.Add(image);
             _myDbContext.SaveChangesAsync();

            return image;
        }

        public async Task<Image> GetImageByUserId(string userId)
        {
            return await _myDbContext.Images.FirstOrDefaultAsync(i => i.UserId == userId);


        }

        public async Task<Image> GetImageByRestaurantId(Guid userId)
        {
            return await _myDbContext.Images.FirstOrDefaultAsync(i => i.RestaurantID == userId);


        }


    }
}
