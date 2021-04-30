using Microsoft.AspNetCore.Mvc;
using ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using System.Threading.Tasks;

namespace ResturantReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResturantController : ControllerBase
    {
        private readonly ICreateRestaurantService _createRestaurantService;
        public ResturantController(ICreateRestaurantService createRestaurantService)
        {
            _createRestaurantService = createRestaurantService;
        }

        [HttpPost("CreateResturant")]

        public async Task<ActionResult<CreateRestaurantResponse>> CreateResturantController([FromBody] CreateRestaurantCommand createResturantCommand)
        {
            
            return Ok(await _createRestaurantService.CreateRestaurant(createResturantCommand));


        }



    }
}
