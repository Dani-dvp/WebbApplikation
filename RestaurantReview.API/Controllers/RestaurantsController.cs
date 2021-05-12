﻿using Microsoft.AspNetCore.Mvc;
using RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.DeleteRestaurant;
using RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery;
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
        private readonly ICategoryListQuery _resturantListQueryService;
        private readonly IRestaurantDetailService _restaurantDetailService;

        public RestaurantsController
            (ICreateRestaurantService createRestaurantService, IDeleteRestaurantService deleteResturantService
            , IUpdateRestaurantService updateResturantService, ICategoryListQuery resturantListQueryService
            , IRestaurantDetailService restaurantDetailService)
        {
            _createRestaurantService = createRestaurantService;
            _deleteResturantService = deleteResturantService;
            _updateResturantService = updateResturantService;
            _resturantListQueryService = resturantListQueryService;
            _restaurantDetailService = restaurantDetailService;

        }

        [HttpPost]

        public async Task<ActionResult<CreateRestaurantResponse>> CreateRestaurantController([FromBody] CreateRestaurantCommand createRestaurantCommand)
        {

            return Ok(await _createRestaurantService.CreateRestaurant(createRestaurantCommand));


        }





        [HttpDelete]

        public async Task<string> DeleteResturantController(DeleteRestaurantCommand deleteResturantCommand)
        {
            return await _deleteResturantService.DeleteRestaurant(deleteResturantCommand);
        }


        [HttpPut]
        public async Task<UpdateRestaurantRespone> UpdateRestaurant(UpdateRestaurantCommand updateRestaurantCommand)
        {
            // funkar men om jag vill uppdatera resturang namn ska vi kunna göra det? tänk om man skriver fel resturang namn ska man behöva deleta den?
            return await _updateResturantService.UpdateRestaurant(updateRestaurantCommand);
        }


        [HttpGet]

        public async Task<List<ResturantListQueryResponse>> GetRestaurantList()
        {
            return await _resturantListQueryService.GetRestaurantList();
        }

        [HttpGet("{ResturantID}")]

        public async Task<RestaurantDetalResponse> GetRestaurantByID([FromQuery] RestaurantDetailCommand restaurantDetailCommand)
        {
            return await _restaurantDetailService.GetRestaurantByID(restaurantDetailCommand);
        }

    }
}