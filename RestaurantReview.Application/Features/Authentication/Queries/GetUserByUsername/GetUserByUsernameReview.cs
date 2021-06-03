using System;

namespace RestaurantReview.Application.Features.Authentication.Queries.GetUserByUsername
{
    public class GetUserByUsernameReview
    {
        public Guid ReviewID { get; set; }

        public string ApplicationUserId { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public string RestaurantName { get; set; }

        public Guid RestaurantID { get; set; }
    }
}