using AutoMapper;
using RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class GetRestaurantListHandler : IGetRestaurantListService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        public GetRestaurantListHandler(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public async Task<List<GetRestaurantListResponse>> GetRestaurantList()
        {
            var restaurantListResponse = new List<GetRestaurantListResponse>();
            var listOfRestaurants = await _restaurantRepository.IncludeEverything();

            foreach (var restaurant in listOfRestaurants)
            {
                var getRestaurantListResponse = _mapper.Map<GetRestaurantListResponse>(restaurant);
                getRestaurantListResponse.ReviewDtoResponses = _mapper.Map<List<ReviewDtoResponse>>(restaurant.Reviews);
                getRestaurantListResponse.CategoryDtoResponses = _mapper.Map<List<CategoryDtoResponse>>(restaurant.Categories);
                getRestaurantListResponse.ImageDtoResponses = _mapper.Map<List<ImageDtoResponse>>(restaurant.Images);

                restaurantListResponse.Add(getRestaurantListResponse);
            }

            return restaurantListResponse;
        }
    }
}
