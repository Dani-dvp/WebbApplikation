using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
   public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<Category> GetCategoryByName(string name);
    }
}
