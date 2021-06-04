using RestaurantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.Application.Features.Images.NewFolder
{
    public interface IGetImageService
    {
        Task<Image> GetImageByName(string userid);
    }
}
