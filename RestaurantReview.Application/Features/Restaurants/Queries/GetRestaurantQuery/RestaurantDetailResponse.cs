using RestaurantReview.Domain.Models;
using System.Collections.Generic;

namespace RestaurantReview.Application.Features.Restaurants.Queries.GetRestaurantQuery
{
    public class RestaurantDetailResponse
    {
        //Response klass som innehåller det man vill skicka tillbaka

        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string RestaurantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }

        public List<Review> Reviews { get; set; }
    }
}