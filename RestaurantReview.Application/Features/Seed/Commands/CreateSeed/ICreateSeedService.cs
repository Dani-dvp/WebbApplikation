using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Seed.Commands.CreateSeed
{
    public interface ICreateSeedService
    {
        Task<string> CreateSeed();
    }
}
