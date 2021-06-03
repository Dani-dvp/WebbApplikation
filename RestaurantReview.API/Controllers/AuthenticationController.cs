using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Authentication.Commands.Login;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IRegistrationService _registrationService;
        private readonly IGetUserByEmailService _getUserByEmailService;
        private readonly IGetUserByUsernameService _getUserByUsernameService;


        public AuthenticationController(IAuthenticationService authenticationService, IRegistrationService registrationService, IGetUserByEmailService getUserByEmailService, IGetUserByUsernameService getUserByUsernameService)
        {
            _authenticationService = authenticationService;
            _registrationService = registrationService;
            _getUserByEmailService = getUserByEmailService;
            _getUserByUsernameService = getUserByUsernameService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateAsync(AuthenticationCommand request)
        {
            return Ok(await _authenticationService.AuthenticateAsync(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> RegisterAsync(RegistrationCommand request)
        {
            return Ok(await _registrationService.RegisterAsync(request));
        }

        [Authorize]
        [HttpGet("user/email/{email}")]
        public async Task<ActionResult<GetUserByEmailResponse>> GetUserByEmailAsync([FromRoute] string email)
        {
            return Ok(await _getUserByEmailService.GetUserByEmail(email));
        }

        [Authorize]
        [HttpGet("user/{username}")]
        public async Task<ActionResult<GetUserByEmailResponse>> GetUserByUsernameAsync([FromRoute] string username)
        {
            return Ok(await _getUserByUsernameService.GetUserByUsername(username));
        }

        [Authorize]
        [HttpGet("token")]
        public bool CheckIfTokenIsValid()
        {
            return true;
        }
    }
}
