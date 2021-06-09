using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryResponse : BaseResponse
    {
        public string CategoryName { get; set; }

    }
}
