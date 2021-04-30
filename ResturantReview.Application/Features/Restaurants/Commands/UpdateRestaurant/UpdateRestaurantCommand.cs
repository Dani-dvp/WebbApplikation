namespace ResturantReview.Application.Features.Restaurants.Commands.UpdateRestaurant
{
    public class UpdateRestaurantCommand
    {
        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string ResturantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }
    }
}