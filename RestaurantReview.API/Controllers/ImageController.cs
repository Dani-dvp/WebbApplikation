﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Images;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ImageResponse> Index(IFormFile file, string email, string restaurantName)
        {
            

            return await _imageService.CreateImagePath(file, email, restaurantName);



        }

    }
}
