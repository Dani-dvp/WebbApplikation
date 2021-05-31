using RestaurantReview.Domain.Models;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class ResturantListQueryResponse
    {
        public string RestaurantName { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }

    }
}