namespace RestaurantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommand
    {
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string RestaurantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }
    }
}