using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.CreateCategory
{
   public interface ICreateCategoryService
    {
        Task<CreateCategoryResponse> CreateCategory(CreateCategoryCommand createCategoryCommand);
    }
}
