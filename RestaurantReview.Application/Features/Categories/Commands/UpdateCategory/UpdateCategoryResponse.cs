using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryResponse : BaseResponse
    {
        public string RestaurantCategory { get; set; }
    }
}