using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IRestaurantRepository : IAsyncRepository<Restaurant>
    {
        Task<Restaurant> GetRestaurantByName(string Name);

        Task<int> RestaurantReviewCount(string name);

  

    }
}
