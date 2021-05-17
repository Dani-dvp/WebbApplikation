using RestaurantReview.Application.ValidationResponse;

namespace ResturantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public class UpdateReviewResponse : BaseResponse
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
