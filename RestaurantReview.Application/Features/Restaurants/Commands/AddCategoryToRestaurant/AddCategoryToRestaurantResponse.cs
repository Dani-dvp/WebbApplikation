using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{
    public class AddCategoryToRestaurantResponse : BaseResponse
    {
        public string RestaurantName { get; set; }
        public string CategoryName { get; set; }
    }
}
