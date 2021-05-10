using RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery;
<<<<<<< HEAD
using System.Collections.Generic;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> main
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery
{
    public interface IReviewListQueryService
    {
        Task<List<ReviewListQueryResponse>> GetReviewList();
    }
}
