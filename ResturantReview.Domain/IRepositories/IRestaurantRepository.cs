using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Domain.IRepositories
{
    public interface IRestaurantRepository : IAsyncRepository<Resturant>
    {
        Task<Resturant> GetResturantByName(string Name);


    }
}
