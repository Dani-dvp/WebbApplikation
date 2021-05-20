using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantByNameQuery
{
    public class GetRestaurantByNameCommand
    {
        public string RestaurantName { get; set; }
    }
}
