using AutoMapper;
using RestaurantReview.Application.Features.Restaurants.Queries.RestaurantAvgRating;
using RestaurantReview.Domain.IRepositories;
using System.Threading.Tasks;
namespace RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating
{
    public class RestaurantAvgRatingHandler : IRestaurantAvgRatingService
    {
        private readonly IMapper _mapper;

        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;


        public RestaurantAvgRatingHandler(IMapper mapper, IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _reviewRepository = reviewRepository;

        }

        public async Task<double> RestaurantAvgRating(RestaurantAvgRatingCommand restaurantAvgRatingCommand)
        {
            // var findRestaurant = _restaurantRepository.GetRestaurantByName(restaurantAvgRatingCommand.RestaurantName);




            var avgRestaurantRat = await _reviewRepository.RestaurantAvgRating(restaurantAvgRatingCommand.RestaurantID);

            return avgRestaurantRat;








        }
    }
}
