using System;

namespace ResturantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public class UpdateReviewCommand
    {
        public Guid ReviewID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }


    }
}
