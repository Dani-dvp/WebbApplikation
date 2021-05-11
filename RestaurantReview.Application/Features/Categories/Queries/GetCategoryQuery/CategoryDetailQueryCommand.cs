using System;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryQuery
{
    public class CategoryDetailQueryCommand
    {
        public Guid CategoryID { get; set; }
    }
}