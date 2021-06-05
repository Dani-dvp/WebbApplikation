
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RestaurantReview.Domain.AuthenticationModels;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.IO;
using System.Threading.Tasks;




namespace RestaurantReview.Application.Features.Images.Commands.CreateImage
{

    public class ImageHandler : IImageService
    {

        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IRestaurantRepository _restaurantRepository;
        public ImageHandler(IMapper mapper, IImageRepository imageRepository, UserManager<ApplicationUser> userManager, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _imageRepository = imageRepository;
            _userManager = userManager;
            _restaurantRepository = restaurantRepository;
        }
        public async Task<ImageResponse> CreateImagePath(IFormFile file, string email, string restaurantName)
        {
            ApplicationUser user = null;
            Restaurant restaurant = null;

            //  sparar namnet på den fil du väljer i filename
            string fileName = Path.GetFileName(file.FileName);

            // skapar en file path där jag vill att filerna ska gå till
            string filePath = "Images/" + fileName;


            //detta måstes göra för att filerna ska komma in i pathen det FileStream gör så vi kan välja en bild och file.create(filePath) skapar eller överskriver
            // en file path som vi vill använda i detta fall /images + fileName file.CopyTo(fileStream) gör så det kopieras till dit du vill i detta fall fileStream
            using (FileStream fileStream = File.Create(filePath))
            {
                file.CopyTo(fileStream);

            }



            //Save the Image File in Folder.
            if (email != null)
            {
                user = await _userManager.FindByEmailAsync(email);
            }

            if (restaurantName != null)
            {
                restaurant = await _restaurantRepository.GetRestaurantByName(restaurantName);
            }




            var image = new Image()
            {
                UserId = user.Id,
                ImgName = fileName,
                ImgPath = filePath,
                ImageID = new Guid(),
                Restaurant = restaurant,
                ApplicationUser = user

            };

            if (user != null)
            {
                image.UserId = user.Id;
            }
            if (restaurant != null)
            {
                image.RestaurantID = restaurant.RestaurantID;
            }

            image = _imageRepository.Add(image);

            var imageResponse = _mapper.Map<ImageResponse>(image);



            //  var imageResponse = _mapper.Map<ImageResponse>(image);

            return imageResponse;

        }

    }
}