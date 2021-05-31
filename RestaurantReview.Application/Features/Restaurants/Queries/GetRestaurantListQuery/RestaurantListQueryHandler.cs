using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class RestaurantListQueryHandler : ICategoryListQuery
    {
        private readonly IMapper _mapper;

        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantListQueryHandler(IMapper mapper, IRestaurantRepository restaurantRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
        }

        public async Task<List<ResturantListQueryResponse>> GetRestaurantList()
        {
            var ListOfRestaurantsAndCategory = await _restaurantRepository.IncludeCategories();

            var listOfRestaurantResponse = _mapper.Map<List<ResturantListQueryResponse>>(ListOfRestaurantsAndCategory);

            return listOfRestaurantResponse;
        }

    }
}