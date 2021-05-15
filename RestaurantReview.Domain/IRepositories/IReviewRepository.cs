using RestaurantReview.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IReviewRepository : IAsyncRepository<Review>
    {
        Task<double> RestaurantAvgRating(Guid id);
    }
}
