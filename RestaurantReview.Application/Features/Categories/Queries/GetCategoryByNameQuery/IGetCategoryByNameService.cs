using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Categories.Queries.GetCategoryByNameQuery
{
    public interface IGetCategoryByNameService
    {
        Task<GetCategoryByNameResponse> GetCategoryByName(string categoryname);
    }
}
