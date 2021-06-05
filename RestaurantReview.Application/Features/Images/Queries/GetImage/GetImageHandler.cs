using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.Queries.GetImage
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

        public async Task<GetImageResponse> GetImageByName(string userEmail)
        {
            var image = await _imageRepository.GetImageByEmail(userEmail);


            var imageresponse = _mapper.Map<GetImageResponse>(image);

            return imageresponse;


        }
    }
}
