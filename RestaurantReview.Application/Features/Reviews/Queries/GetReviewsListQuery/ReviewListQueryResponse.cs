using System;

namespace RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery
{
    public class ReviewListQueryResponse
    {
        public Guid ReviewID { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public string RestaurantName { get; set; }

        public Guid RestaurantID { get; set; }


    }
}
