using System;

namespace RestaurantReview.Domain.Models
{
    public class Review
    {
        public Review()
        {

        }
        public Guid ReviewID { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }

        public string ReviewTest { get; set; }

        public int Rating { get; set; }

        public Guid RestaurantID { get; set; }

        public Restaurant Restaurant { get; set; }

    }
}
