using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantRespone : BaseResponse
    {
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string RestaurantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }


    }
}