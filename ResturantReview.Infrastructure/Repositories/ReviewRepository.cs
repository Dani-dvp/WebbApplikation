
using ResturantReview.Domain.IRepositories;
using ResturantReview.Domain.Models;

namespace ResturantReview.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MyDbContext dbContext) : base(dbContext)
        {

        }
    }
}