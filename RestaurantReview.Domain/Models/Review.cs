using System;

namespace RestaurantReview.Domain.Models
{
    public class Review
    {
        public Guid ReviewID { get; set; }

        public string ApplicationUserId { get; set; }

        public string UserName { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid RestaurantID { get; set; }

        public string RestaurantName { get; set; }

        public Restaurant Restaurant { get; set; }



    }
}
