
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
    }
}