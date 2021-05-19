namespace RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand
    {

        public string RestaurantName { get; set; }
        public string Category { get; set; }
        public string MapURL { get; set; }

    }
}