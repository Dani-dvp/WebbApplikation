
using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        protected new readonly MyDbContext _myDbContext;
        public ReviewRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Task<double> RestaurantAvgRating(Guid  id)
        {
            var avgReview = _myDbContext.Reviews.Where(review => review.RestaurantID == id).AverageAsync(review => review.Rating); //AverageAsync(review => review.Rating)

            return avgReview;


        }

        public async Task<List<Review>> GetReviewsByRestaurantId(Guid id)
        {
         return await   _myDbContext.Reviews.Include(review => review.Restaurant).ThenInclude(restaurant => restaurant.Categories).Where(review => review.RestaurantID == id).ToListAsync();
        }
    }
}