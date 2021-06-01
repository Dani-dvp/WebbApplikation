using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RestaurantReview.Domain.AuthenticationModels;
using RestaurantReview.Domain.IRepositories;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public class GetUserByEmailHandler : IGetUserByEmailService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        public GetUserByEmailHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IImageRepository imageRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _imageRepository = imageRepository;
        }

        public async Task<GetUserByEmailResponse> GetUserByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var image = await _imageRepository.GetImageByUserId(user.Id);

            var userResponse = _mapper.Map<GetUserByEmailResponse>(user);
            userResponse.GetUserImageResponse = _mapper.Map<GetUserImageResponse>(image);
            return userResponse;
        }
    }
}
