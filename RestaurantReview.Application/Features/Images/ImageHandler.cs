
using AutoMapper;
using Microsoft.AspNetCore.Http;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.IO;
using System.Web;




namespace RestaurantReview.Application.Features.Images
{

    public class ImageHandler : IImageService
    {

        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        public ImageHandler(IMapper mapper, IImageRepository imageRepository)
        {
            _mapper = mapper;
            _imageRepository = imageRepository;
        }
        public ImageResponse CreateImagePath( IFormFile file )
        {

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
          


            var image = new Image()
            {
                ImgName = fileName,
                ImgPath = filePath,
                ImageID = new Guid()
            };
           
            image = _imageRepository.Add(image);
            
         var imageResponse = _mapper.Map<ImageResponse>(image);

           

           //  var imageResponse = _mapper.Map<ImageResponse>(image);

            return imageResponse;

               

        }

    }
}