using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.NewFolder
{
    public class GetImageHandler : IGetImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;
        public GetImageHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<Image> GetImageByName(string userid)
        {
            var image = await _imageRepository.GetImageByUserId(userid);


            //var imageFileStream = File.OpenRead(image.ImgPath);

            ////var imagefile = imageFileStream.ReadAsync()

            //    using (FileStream fs = File.OpenRead(image.ImgPath))
            //{
            //    byte[] b = new byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding(true);

            //    while (fs.Read(b, 0, b.Length) > 0)
            //    {
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}

            //var imageresponse = _mapper.Map<GetImageResponse>(image);



            return image;


        }
    }
}
