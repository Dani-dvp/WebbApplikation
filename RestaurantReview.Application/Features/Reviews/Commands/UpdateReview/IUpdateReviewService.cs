using ResturantReview.Application.Features.Reviews.Commands.UpdateReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Commands.UpdateReview
{
    public interface IUpdateReviewService
    {
        Task<UpdateReviewResponse> UpdateReview(UpdateReviewCommand updateReviewCommand);
    }
}
