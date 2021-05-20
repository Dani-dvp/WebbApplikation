using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{
    public class AddCategoryToRestaurantCommand
    {
        public string RestaurantName { get; set; }
        public string CategoryName { get; set; }

    }
}
