using RestaurantReview.Application.ValidationResponse;

namespace RestaurantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantResponse : BaseResponse
    {

        //En kopia av Modellen som ska skickas tillbaka, ska bara innehålla den informationen som är relevant till denna metoden

        public string RestaurantName { get; set; }
        public string Category { get; set; }

    }
}
