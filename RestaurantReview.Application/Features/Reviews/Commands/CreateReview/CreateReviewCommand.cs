namespace ResturantReview.Application.Features.Reviews.Commands.CreateReview
{
    public class CreateReviewCommand
    {

        public string RestaurantName { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }


    }
}
