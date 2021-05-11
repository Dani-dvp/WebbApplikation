using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.UpdateCategory
{
   public interface IUpdateCategoryService
    {
        Task<UpdateCategoryResponse> UpdateCategory(UpdateCategoryCommand updateCategoryCommand);
    }
}
