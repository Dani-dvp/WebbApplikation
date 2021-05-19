
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
        public Image CreateImagePath( IFormFile file )
        {
            string fileName = Path.GetFileName(file.FileName);


            string filePath = "Images/" + fileName;


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


            image =  _imageRepository.Add(image);

           //  var imageResponse = _mapper.Map<ImageResponse>(image);

            return image;

               

        }

    }
}