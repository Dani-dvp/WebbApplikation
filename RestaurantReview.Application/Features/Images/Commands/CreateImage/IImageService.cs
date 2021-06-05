using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.Commands.CreateImage
{
    public interface IImageService
    {
        Task<ImageResponse> CreateImagePath(IFormFile file, string email, string restaurantName);
    }
}