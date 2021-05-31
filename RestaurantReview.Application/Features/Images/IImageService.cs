using Microsoft.AspNetCore.Http;
using RestaurantReview.Domain.Models;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images
{
    public interface IImageService
    {
        Task<ImageResponse> CreateImagePath(IFormFile file, string email, string restaurantName);
    }
}