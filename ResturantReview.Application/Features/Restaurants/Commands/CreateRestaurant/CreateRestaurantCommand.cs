using ResturantReview.Domain.Models;
using System.Collections.Generic;

namespace ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand
    {
  
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string StreetPhoto { get; set; }

    }
}