using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommand : BaseResponse
    {
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string RestaurantLink { get; set; }

        public string MapURL { get; set; }

        public string StreetPhoto { get; set; }
    }
}