using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public interface ICreateRestaurantService
    {
        Task<CreateRestaurantResponse> CreateRestaurant(CreateRestaurantCommand createRestaurantCommand);
    }
}
