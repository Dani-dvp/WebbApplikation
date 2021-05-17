using System;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestaurantListQuery.RestaurantReviews
{
    public class ReviewDtoResponse
    {
        public Guid ReviewID { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public Guid RestaurantID { get; set; }


    }
}