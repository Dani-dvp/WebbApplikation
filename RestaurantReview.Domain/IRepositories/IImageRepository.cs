using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IImageRepository : IAsyncRepository<Image>
    {
        Image Add(Image image);
    }
}
