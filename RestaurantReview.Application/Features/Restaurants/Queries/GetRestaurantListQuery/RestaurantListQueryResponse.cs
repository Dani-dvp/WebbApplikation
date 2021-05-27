using RestaurantReview.Domain.Models;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantListQuery
{
    public class ResturantListQueryResponse
    {
        public string RestaurantName { get; set; }
        public List<Category> Category { get; set; }
    }
}