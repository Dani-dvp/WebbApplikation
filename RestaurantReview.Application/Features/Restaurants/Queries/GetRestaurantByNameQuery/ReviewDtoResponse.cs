using System;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class ReviewDtoResponse
    {
        public Guid ReviewID { get; set; }

        public string ApplicationUserId { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid RestaurantID { get; set; }

        public string RestaurantName { get; set; }
    }
}