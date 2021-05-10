using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly ICreateRestaurantService _createRestaurantService;
        public RestaurantController(ICreateRestaurantService createRestaurantService)
        {
            _createRestaurantService = createRestaurantService;
        }

        [Authorize]
        [HttpPost("CreateRestaurant")]

        public async Task<ActionResult<CreateRestaurantResponse>> CreateRestaurantController([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {

            return Ok(await _createRestaurantService.CreateRestaurant(createRestaurantCommand));


        }



    }
}
