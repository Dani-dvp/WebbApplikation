using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantReviewCountQuery
{
    public class RestaurantReviewCountHandler : IRestaurantReviewCountService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;
        public RestaurantReviewCountHandler(IMapper mapper, IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            _restaurantRepository = restaurantRepository;
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<RestaurantReviewCountResponse> RestaurantReviewsCount(RestaurantReviewCountCommand restaurantReviewCommand)
        {
            var getResturant = await _restaurantRepository.GetRestaurantByName(restaurantReviewCommand.RestaurantName);


            var countReviewsInRestaurant = await _restaurantRepository.RestaurantReviewCount(getResturant.RestaurantID);

            var countReviewsInRestaurantResponse = _mapper.Map<RestaurantReviewCountResponse>(countReviewsInRestaurant);

            return countReviewsInRestaurantResponse;
        }

    }
}