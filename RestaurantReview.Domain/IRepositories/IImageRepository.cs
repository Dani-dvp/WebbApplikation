using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IImageRepository : IAsyncRepository<Image>
    {
        Image Add(Image image);

        Task<Image> GetImageByUserId(string userId);

        Task<Image> GetImageByRestaurantId(Guid userId);

        Task<Image> GetImageByEmail(string userEmail);
    }
}
