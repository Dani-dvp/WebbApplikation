using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryResponse : BaseResponse
    {
        public string CategoryName { get; set; }
    }
}
