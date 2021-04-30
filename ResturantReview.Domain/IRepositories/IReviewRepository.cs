using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResturantReview.Domain.IRepositories
{
    public interface IReviewRepository : IAsyncRepository<Review>
    {
    }
}
