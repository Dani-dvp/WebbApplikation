using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Authentication.Commands.Login;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Authentication.Queries.GetUserByEmail;
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
        public AuthenticationController(IAuthenticationService authenticationService, IRegistrationService registrationService, IGetUserByEmailService getUserByEmailService)
        {
            _authenticationService = authenticationService;
            _registrationService = registrationService;
            _getUserByEmailService = getUserByEmailService;
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
        [HttpGet("user")]
        public async Task<ActionResult<GetUserByEmailResponse>> GetUserByEmailAsync(GetUserByEmailCommand getUserByEmailCommand)
        {
            return Ok(await _getUserByEmailService.GetUserByEmail(getUserByEmailCommand));
        }
    }
}
