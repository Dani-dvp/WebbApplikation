using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReview.Domain.IRepositories
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {

        //Kopior av task ifrån vanliga repositories:
        //exempel:
        //Task<TEntity> GetByIdAsync(double ID);
        Task<TEntity> GetByIdAsync(Guid ID);

        


        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);


    }
}
