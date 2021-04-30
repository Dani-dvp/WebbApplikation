using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantResponse
    {

        //En kopia av Modellen som ska skickas tillbaka, ska bara innehålla den informationen som är relevant till denna metoden
        
        public string RestaurantName { get; set; }
        public string Category { get; set; }

    }
}
