using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetThreeRandomRestaurants
{
    public class GetThreeRandomRestaurantsHandler : IGetThreeRandomRestaurantsService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        public GetThreeRandomRestaurantsHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<List<GetThreeRandomRestaurantsResponse>> GetThreeRandomResturants()
        {
            var listOfResturants = await _restaurantRepository.ListAllAsync();

            var threeRandomRestaurants = listOfResturants.OrderBy(arg => Guid.NewGuid()).Take(3).ToList();

            var threeRandomRestaurantsResponse = _mapper.Map<List<GetThreeRandomRestaurantsResponse>>(threeRandomRestaurants);

            return threeRandomRestaurantsResponse;

        }


    }
}
