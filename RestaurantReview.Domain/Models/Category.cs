
using System;
using System.Collections.Generic;


namespace RestaurantReview.Domain.Models
{
    public class Category
    {
        public Category()
        {
            Restaurants = new List<Restaurant>();
        }


        public Guid CategoryID { get; set; }

        public string RestaurantCategory { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
