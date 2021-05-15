using System;
using System.Collections.Generic;

namespace RestaurantReview.Domain.Models
{
    public class Restaurant
    {
        public Guid RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string RestaurantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }

     

        public List<Review> Reviews { get; set; }

        public List<Category> Categories { get; set; }



    }
}
