using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Images;
using RestaurantReview.Application.Features.Images.NewFolder;
using RestaurantReview.Domain.Models;
using System.IO;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IGetImageService _getImageService;
        public ImageController(IImageService imageService, IGetImageService getImageService)
        {
            _imageService = imageService;
            _getImageService = getImageService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ImageResponse> Index(IFormFile file, string email, string restaurantName)
        {
            

            return await _imageService.CreateImagePath(file, email, restaurantName);



        }

        //[HttpGet]
        //public async Task<File> GetImageByUserid(string userId)
        //{
        //    return await _getImageService.GetImageByName(userId);
        //}

        [HttpGet]
        public async Task<IActionResult> Get(string userid)
        {
            Image image = await _getImageService.GetImageByName(userid);
            var imageresponse = System.IO.File.OpenRead(image.ImgPath);
            return File(imageresponse, "image/jpeg");
        }

    }
}
