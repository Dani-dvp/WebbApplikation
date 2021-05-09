using RestaurantReview.Domain.Models;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IRestaurantRepository : IAsyncRepository<Restaurant>
    {
        Task<Restaurant> GetRestaurantByName(string Name);


    }
}
