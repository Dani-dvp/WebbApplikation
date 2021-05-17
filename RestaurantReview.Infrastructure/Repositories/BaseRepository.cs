using Microsoft.EntityFrameworkCore;
using RestaurantReview.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace RestaurantReview.Infrastructure.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly MyDbContext _myDbContext;
        public BaseRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        //Här körs anroppen mot databasen

        //Väldigt viktigt att i BaseRepository ska endast finnas metoder som flera klasser ska använda sig utav
        //Annars ska man skriva det i den specifika repositorien. Tex ModelRepository

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _myDbContext.Set<T>().FindAsync(id);
        }




        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _myDbContext.Set<T>().ToListAsync();
        }



        public async Task<T> AddAsync(T entity)
        {
            await _myDbContext.Set<T>().AddAsync(entity);
            await _myDbContext.SaveChangesAsync();

            return entity;
        }

        /*  public async Task UpdateAsync(T entity)
          {
              _myDbContext.Entry(entity).State = _myDbContext.Modified;
              await _myDbContext.SaveChangesAsync();
          } */

        public async Task DeleteAsync(T entity)
        {
            _myDbContext.Set<T>().Remove(entity);
            await _myDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _myDbContext.Update(entity);
            await _myDbContext.SaveChangesAsync();

        }

     



    }
}

