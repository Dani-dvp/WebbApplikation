using RestaurantReview.Application.ValidationResponse;

namespace ResturantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public class UpdateReviewResponse : BaseResponse
    {
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
