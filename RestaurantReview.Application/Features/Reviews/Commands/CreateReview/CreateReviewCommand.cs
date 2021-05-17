namespace ResturantReview.Application.Features.Reviews.Commands.CreateReview
{
    public class CreateReviewCommand
    {
        public string RestaurantName { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }


    }
}
