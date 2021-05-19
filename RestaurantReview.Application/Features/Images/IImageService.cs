using Microsoft.AspNetCore.Http;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Application.Features.Images
{
    public interface IImageService
    {
        Image CreateImagePath(  IFormFile file);
    }
}