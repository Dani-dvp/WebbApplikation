using System;

namespace RestaurantReview.Application.Features.Restaurants.Queries.RestauranAvgRating
{
    public class RestaurantAvgRatingCommand
    {
        public string RestaurantName { get; set; }
        public string TotalRating { get; set; }

        public Guid RestaurantID { get; set; }
    }
}