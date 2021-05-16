using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews
{
    public class RestaurantReviewsHandler : IRestaurantReviewsService
    {

        private readonly IMapper _mapper;
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;


        public RestaurantReviewsHandler(IMapper mapper, IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _reviewRepository = reviewRepository;
        }


        public async Task<RestaurantReviewsResponse> GetRestaurantReviews(RestaurantReviewsCommand restaurantReviewsCommand)
        {

            var restaurant= await _restaurantRepository.GetRestaurantByName(restaurantReviewsCommand.RestaurantName);
         


            var review = _reviewRepository.GetReviewsByRestaurantId(restaurant.RestaurantID);

             var restaurantReviewsResponse = new RestaurantReviewsResponse()
              {
                  RestaurantName = restaurant.RestaurantName,
                  RestaurantDtoResponse = _mapper.Map<RestaurantDtoResponse>(restaurant),
                 ReviewsDtoResponses = _mapper.Map<List<ReviewDtoResponse>>(review)


        }; 
         //   var restaurantReviewsResponse =new RestaurantReviewsResponse();
              

           //  restaurantReviewsResponse.RestaurantDtoResponse =  _mapper.Map<RestaurantDtoResponse>(restaurant);

           // restaurantReviewsResponse.ReviewsDtoResponses =  _mapper.Map<List<ReviewDtoResponse>>(review);

           

            return restaurantReviewsResponse;

        } 

    }

}