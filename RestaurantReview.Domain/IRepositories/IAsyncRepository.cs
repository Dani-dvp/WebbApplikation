using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReview.Domain.IRepositories
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {

        Task<TEntity> GetByIdAsync(Guid ID);


        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);


    }
}
