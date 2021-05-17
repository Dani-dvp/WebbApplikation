using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RestaurantReview.Domain.AuthenticationModels;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail
{
    public class GetUserByEmailHandler : IGetUserByEmailService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        public GetUserByEmailHandler(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<GetUserByEmailResponse> GetUserByEmail(GetUserByEmailCommand getUserCommand)
        {
            var user = await _userManager.FindByEmailAsync(getUserCommand.Email);
            var userResponse = _mapper.Map<GetUserByEmailResponse>(user);
            return userResponse;
        }
    }
}
