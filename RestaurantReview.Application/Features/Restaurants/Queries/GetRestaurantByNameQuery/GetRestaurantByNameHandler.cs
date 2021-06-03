using AutoMapper;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetRestaurantByNameHandler : IGetRestaurantByNameService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;
        public GetRestaurantByNameHandler(IRestaurantRepository restaurantRepository, IMapper mapper, IReviewRepository reviewRepository, IImageRepository imageRepository)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
            _reviewRepository = reviewRepository;
            _imageRepository = imageRepository;
        }

        public async Task<GetRestaurantByNameResponse> GetRestaurantByName(GetRestaurantByNameCommand getRestaurantByNameCommand)
        {
            var restaurant = await _restaurantRepository.GetRestaurantByName(getRestaurantByNameCommand.RestaurantName);
            if (restaurant == null)
            {
                throw new Exception();
            }
            var restaurantResponse = _mapper.Map<GetRestaurantByNameResponse>(restaurant);

            var listOfReviews = await _reviewRepository.GetReviewsByRestaurantId(restaurant.RestaurantID);
            restaurantResponse.ReviewsDtoResponse = _mapper.Map<List<ReviewDtoResponse>>(listOfReviews);

            var image = await _imageRepository.GetImageByRestaurantId(restaurant.RestaurantID);

            restaurantResponse.GetImageForRestaurantResponse = _mapper.Map<GetImageForRestaurantResponse>(image);

            return restaurantResponse;
        }

    }
}
