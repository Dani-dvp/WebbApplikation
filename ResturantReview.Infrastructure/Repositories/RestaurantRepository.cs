
using ResturantReview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using ResturantReview.Domain.IRepositories;

namespace ResturantReview.Infrastructure.Repositories
{
    public class RestaurantRepository : BaseRepository<Resturant>, IRestaurantRepository
    {
        protected new readonly MyDbContext _myDbContext;


        public RestaurantRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<Resturant> GetResturantByName(string Name)
        {
           var Resturant =  await _myDbContext.Set<Resturant>().FirstOrDefaultAsync(resturant => resturant.ResturantName == Name);
            return Resturant;
        }
    }
}
