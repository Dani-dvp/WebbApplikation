using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.AddRestaurantToCategory
{
    public class AddRestaurantToCategoryCommand
    {
        public string RestaurantName { get; set; }

        public string CategoryName { get; set; }
    }
}
