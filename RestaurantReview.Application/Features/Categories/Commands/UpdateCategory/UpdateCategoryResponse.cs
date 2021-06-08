using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryResponse : BaseResponse
    {
        public string CategoryName { get; set; }
    }
}