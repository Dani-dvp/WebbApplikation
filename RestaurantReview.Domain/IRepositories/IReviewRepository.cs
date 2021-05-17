using RestaurantReview.Domain.Models;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IReviewRepository : IAsyncRepository<ReviewToBeUpdated>
    {
    }
}
