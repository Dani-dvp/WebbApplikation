using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Commands.DeleteCategory
{
public    interface IDeleteCategoryService
    {
        
            Task<string> DeleteCategory(DeleteCategoryCommand deleteCategoryCommand);
      
    }
}
