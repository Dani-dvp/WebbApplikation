using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
using RestaurantReview.Domain.AuthenticationModels;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername
{
    public class GetUserByUsernameHandler : IGetUserByUsernameService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IImageRepository _imageRepository;
        private readonly IReviewRepository _reviewRepository;
        public GetUserByUsernameHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IImageRepository imageRepository, IReviewRepository reviewRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _imageRepository = imageRepository;
            _reviewRepository = reviewRepository;
        }

        public async Task<GetUserByUsernameResponse> GetUserByUsername(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            var image = await _imageRepository.GetImageByUserId(user.Id);
            var listOfReviews = await _reviewRepository.GetReviewsByUserId(user.Id);

            var userResponse = _mapper.Map<GetUserByUsernameResponse>(user);
            userResponse.GetUserImageResponse = _mapper.Map<GetUserImageResponse>(image);
            userResponse.GetUserByUsernameReviews = _mapper.Map<List<GetUserByUsernameReview>>(listOfReviews);
            return userResponse;
        }
    }
}
