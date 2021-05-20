using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IReviewRepository : IAsyncRepository<Review>
    {
        Task<double> RestaurantAvgRating(Guid id);

        Task<List<Review>> GetReviewsByRestaurantId(Guid id);

       // Task<bool> IsEventNameAndDateUnique(string name);
    }
}
