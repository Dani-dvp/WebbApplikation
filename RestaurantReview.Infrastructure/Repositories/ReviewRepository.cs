
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<ReviewToBeUpdated>, IReviewRepository
    {
        public ReviewRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
    }
}