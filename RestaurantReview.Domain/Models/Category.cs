
using System;
using System.Collections.Generic;

using System.Text;


namespace RestaurantReview.Domain.Models
{
    public class Category
    {
        public Guid CategoryID { get; set; }
       
        

        public Guid? RestaurantID { get; set; }
        public string RestaurantCategory { get; set; }

        public List<Restaurant> Restaurants { get; set; }
    }
}
