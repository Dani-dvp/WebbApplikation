using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Authentication.Commands.Login;
using RestaurantReview.Application.Features.Authentication.Commands.Register;
using RestaurantReview.Application.Features.Authentication.Queries.CheckTokenIfValid;
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
        private readonly ICheckIfTokenIsValidService _checkIfTokenIsValidService;
        public AuthenticationController(IAuthenticationService authenticationService, IRegistrationService registrationService, IGetUserByEmailService getUserByEmailService, ICheckIfTokenIsValidService checkIfTokenIsValidService)
        {
            _authenticationService = authenticationService;
            _registrationService = registrationService;
            _getUserByEmailService = getUserByEmailService;
            _checkIfTokenIsValidService = checkIfTokenIsValidService;
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
        public async Task<ActionResult<GetUserByEmailResponse>> GetUserByEmailAsync([FromQuery]GetUserByEmailCommand getUserByEmailCommand)
        {
            return Ok(await _getUserByEmailService.GetUserByEmail(getUserByEmailCommand));
        }

        [Authorize]
        [HttpGet("token")]
        public bool CheckIfTokenIsValid()
        {
            return true;
        }
    }
}
