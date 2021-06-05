using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.Queries.GetImage
{
    public interface IGetImageService
    {
        Task<GetImageResponse> GetImageByName(string userEmail);
    }
}
