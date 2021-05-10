using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateResturant
{
    public class CreateResturantResponse
    {

        //En kopia av Modellen som ska skickas tillbaka, ska bara innehålla den informationen som är relevant till denna metoden
        public Guid ResturantID { get; set; }
        public string ResturantName { get; set; }
        public string Category { get; set; }
       

        public string StreetPhoto { get; set; }

      
    }
}
