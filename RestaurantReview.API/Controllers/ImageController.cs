using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Images;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService  )
        {
            _imageService = imageService;
        }

        [HttpPost]
        public Image Index(IFormFile file)
        {
            //Extract Image File Name.


            return _imageService.CreateImagePath( file);
            

        }

        }
    }
