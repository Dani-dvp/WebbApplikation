

using RestaurantReview.Application.ValidationResponse;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateReview
{
    public class CreateReviewResponse : BaseResponse
    {

        //En kopia av Modellen som ska skickas tillbaka, ska bara innehålla den informationen som är relevant till denna metoden

        public string RestaurantName { get; set; }
        public int Rating { get; set; }
    }
}
