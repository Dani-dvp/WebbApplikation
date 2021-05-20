using AutoMapper;
using Microsoft.AspNetCore.Http;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetRestaurantByNameHandler : IGetRestaurantByNameService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;
        public GetRestaurantByNameHandler(IRestaurantRepository restaurantRepository, IMapper mapper, IReviewRepository reviewRepository)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }

        public async Task<GetRestaurantByNameResponse> GetRestaurantByName(GetRestaurantByNameCommand getRestaurantByNameCommand)
        {
            var restaurant = await _restaurantRepository.GetRestaurantByName(getRestaurantByNameCommand.RestaurantName);
            var restaurantResponse = _mapper.Map<GetRestaurantByNameResponse>(restaurant);

            var listOfReviews = await _reviewRepository.GetReviewsByRestaurantId(restaurant.RestaurantID);
            restaurantResponse.ReviewsDtoResponse = _mapper.Map<List<ReviewDtoResponse>>(listOfReviews);

            return restaurantResponse;
        }

    }
}
