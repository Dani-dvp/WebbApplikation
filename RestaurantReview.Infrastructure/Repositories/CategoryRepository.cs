using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.IRepositories;
using RestaurantReview.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        protected new readonly MyDbContext _myDbContext;
        public CategoryRepository(MyDbContext myDbContext) : base(myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<Category> GetCategoryByName(string name)
        {
            var findResturantCategory = await _myDbContext.Set<Category>().FirstOrDefaultAsync(category => category.RestaurantCategory == name);

            return findResturantCategory;
        }

            public  Task<bool> IsCategoryUnique(string name)
            {
                var matches =  _myDbContext.Categories.Any(category => category.RestaurantCategory.Equals(name));
                return Task.FromResult(matches);
            }

        }



    }



 
