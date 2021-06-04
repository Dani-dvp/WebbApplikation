using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.DeleteRestaurant;

using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetThreeRandomRestaurants;
using RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantAvgRating;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantReviewCountQuery;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly ICreateRestaurantService _createRestaurantService;
        private readonly IDeleteRestaurantService _deleteResturantService;
        private readonly IUpdateRestaurantService _updateResturantService;
        private readonly IRestaurantDetailService _restaurantDetailService;
        private readonly IRestaurantReviewCountService _restaurantReviewCountService;
        private readonly IRestaurantAvgRatingService _restaurantAvgRatingService;
        private readonly IGetRestaurantListService _getRestaurantListService;
        private readonly IGetThreeRandomRestaurantsService _getThreeRandomRestaurantsService;
        private readonly IGetRestaurantByNameService _getRestaurantByNameService;
        private readonly IAddCategoryToRestaurantService _addCategoryToRestaurantService;

        public RestaurantsController
            (ICreateRestaurantService createRestaurantService, IDeleteRestaurantService deleteResturantService
            , IUpdateRestaurantService updateResturantService, IRestaurantDetailService restaurantDetailService, IRestaurantReviewCountService restaurantReviewCountService
            , IRestaurantAvgRatingService restaurantAvgRatingService, IGetRestaurantByNameService getRestaurantByNameService, IGetRestaurantListService getRestaurantListService, IGetThreeRandomRestaurantsService getThreeRandomRestaurantsService, IAddCategoryToRestaurantService addCategoryToRestaurantService)
        {
            _createRestaurantService = createRestaurantService;
            _deleteResturantService = deleteResturantService;
            _updateResturantService = updateResturantService;
            _restaurantDetailService = restaurantDetailService;
            _restaurantReviewCountService = restaurantReviewCountService;
            _restaurantAvgRatingService = restaurantAvgRatingService;
            _getRestaurantByNameService = getRestaurantByNameService;
            _getRestaurantListService = getRestaurantListService;
            _getThreeRandomRestaurantsService = getThreeRandomRestaurantsService;
            _addCategoryToRestaurantService = addCategoryToRestaurantService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<CreateRestaurantResponse>> CreateRestaurantController([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {

            return Ok(await _createRestaurantService.CreateRestaurant(createRestaurantCommand));
        }


        [Authorize]
        [HttpDelete]
        public async Task<string> DeleteResturantController(DeleteRestaurantCommand deleteResturantCommand)
        {
            return await _deleteResturantService.DeleteRestaurant(deleteResturantCommand);
        }

        [Authorize]
        [HttpPut]
        public async Task<UpdateRestaurantRespone> UpdateRestaurant(UpdateRestaurantCommand updateRestaurantCommand)
        {
            // funkar men om jag vill uppdatera resturang namn ska vi kunna göra det? tänk om man skriver fel resturang namn ska man behöva deleta den?
            return await _updateResturantService.UpdateRestaurant(updateRestaurantCommand);
        }


        [HttpGet]
        public async Task<List<GetRestaurantListResponse>> GetRestaurantList()
        {
            return await _getRestaurantListService.GetRestaurantList();
        }


        [HttpGet("{ResturantID}")]
        public async Task<RestaurantDetailResponse> GetRestaurantByID([FromQuery] RestaurantDetailCommand restaurantDetailCommand)
        {
            return await _restaurantDetailService.GetRestaurantByID(restaurantDetailCommand);
        }

        [HttpGet("name/{RestaurantName}")]
        public async Task<GetRestaurantByNameResponse> GetRestaurantByName([FromRoute] GetRestaurantByNameCommand getRestaurantByNameCommand)
        {
            return await _getRestaurantByNameService.GetRestaurantByName(getRestaurantByNameCommand);
        }


        [HttpGet("ReviewCount")]
        public async Task<int> RestaurantReviewCount([FromQuery] RestaurantReviewCountCommand restaurantReviewCountCommand)
        {
            return await _restaurantReviewCountService.RestaurantReviewsCount(restaurantReviewCountCommand);
        }

        [HttpGet("AvgReviewRating")]

        public async Task<double> RestaurantAvgRatingController([FromQuery] RestaurantAvgRatingCommand restaurantAvgRatingCommand)
        {
            return await _restaurantAvgRatingService.RestaurantAvgRating(restaurantAvgRatingCommand);
        }

        [HttpGet("Random")]
        public async Task<List<GetThreeRandomRestaurantsResponse>> GetThreeRandomRestaurants()
        {
            return await _getThreeRandomRestaurantsService.GetThreeRandomResturants();
        }

        [Authorize]
        [HttpPost("addCategory")]
        public async Task<AddCategoryToRestaurantResponse> AddCategoryToRestaurant([FromBody] AddCategoryToRestaurantCommand addCategoryToRestaurantCommand )
        {
            return await _addCategoryToRestaurantService.AddCategoryToRestaurant(addCategoryToRestaurantCommand);
        }


    }
}
