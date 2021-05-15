using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;


namespace RestaurantReview.Application.Features.Restaurants.Commands.RestaurantModel
{
    public class RestaurantHandler
    {

        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;


        public RestaurantHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<Action> Restaurant()
        {
            return null;
        }
    }

}