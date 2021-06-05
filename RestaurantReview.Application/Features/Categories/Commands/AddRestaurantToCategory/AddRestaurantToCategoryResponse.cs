using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory
{
    public class AddRestaurantToCategoryResponse : BaseResponse
    {
        public string RestaurantName { get; set; }

        public string CategoryName { get; set; }

    }
}
