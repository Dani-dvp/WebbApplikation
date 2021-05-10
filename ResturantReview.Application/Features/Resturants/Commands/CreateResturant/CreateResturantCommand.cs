
using System.Collections.Generic;

namespace ResturantReview.Application.Features.Resturants.Commands.CreateResturant
{
    public class CreateResturantCommand
    {

        public string ResturantName { get; set; }
        public string Category { get; set; }
        public string ResturantLink { get; set; }

        public string GoogleMapsPhoto { get; set; }

        public string StreetPhoto { get; set; }


    }
}