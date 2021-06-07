using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Images.Commands.CreateImage;
using RestaurantReview.Application.Features.Images.Queries.GetImage;
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
        [HttpGet("{email}")]
        public async Task<IActionResult> GetImageByEmail([FromRoute]string email)
        {
            var image = await _getImageService.GetImageByName(email);
            if (image != null)
            {
                var imageresponse = System.IO.File.OpenRead(image.ImgPath);
                return File(imageresponse, "image/jpeg");
            }
            else
            {
                return BadRequest();
            }
           
        }

    }
}
