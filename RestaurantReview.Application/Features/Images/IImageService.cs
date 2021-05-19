using Microsoft.AspNetCore.Http;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Application.Features.Images
{
    public interface IImageService
    {
        ImageResponse CreateImagePath(  IFormFile file);
    }
}