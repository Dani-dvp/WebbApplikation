using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Restaurants.Commands.AddCategoryToRestaurant
{
    public interface IAddCategoryToRestaurantService
    {
        Task<AddCategoryToRestaurantResponse> AddCategoryToRestaurant(AddCategoryToRestaurantCommand addCategoryToRestaurantCommand);
    }
}
