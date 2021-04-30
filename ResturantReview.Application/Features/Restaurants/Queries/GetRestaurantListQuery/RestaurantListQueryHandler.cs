using AutoMapper;
using ResturantReview.Application.Features.Resturants.Queries.GetResturantListQuery;
using ResturantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class RestaurantListQueryHandler
    {
        private readonly IMapper _mapper;

        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantListQueryHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<List <RestaurantListQueryResponse>> GetResturantList()
        {
          var listOfResturant = await _restaurantRepository.ListAllAsync();

         var listOfResturantResponse = _mapper.Map <List <RestaurantListQueryResponse>>(listOfResturant);

            return listOfResturantResponse;
        }

    }
}