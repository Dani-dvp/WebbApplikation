using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Seed.Commands.CreateSeed
{
    public interface ICreateSeedService
    {
        Task<string> CreateSeed();
    }
}
