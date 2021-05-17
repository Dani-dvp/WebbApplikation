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

            var restaurantID= await _restaurantRepository.GetRestaurantByName(restaurantReviewsCommand.RestaurantName);





           var restaurant =await  _restaurantRepository.GetByIdAsync(restaurantID.RestaurantID);

            var restaurantResponse = _mapper.Map<RestaurantReviewsResponse>(restaurant);


            var listOfReviews = await _reviewRepository.GetReviewsByRestaurantId(restaurant.RestaurantID);

            var listOfReviewsDtoResponse =  new List<ReviewDtoResponse>();

            foreach (var review in listOfReviews)
            {
               var reviewDto =  _mapper.Map<ReviewDtoResponse>(review);

                 listOfReviewsDtoResponse.Add(reviewDto);
            }


            restaurantResponse.ReviewsDtoResponses = listOfReviewsDtoResponse;


            return restaurantResponse;

        } 

    }

}