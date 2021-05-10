using RestaurantReview.Application.Features.Reviews.Queries.GetReviewListQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Queries.GetReviewsListQuery
{
    public interface IReviewListQueryService
    {
        Task<List<ReviewListQueryResponse>> GetReviewList();
    }
}
