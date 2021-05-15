using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Reviews.Commands.ReviewModel
{
   public interface ICategoryService
    {
        Task<Action> Restaurant();
    }
}
