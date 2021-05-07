using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamiliesPart2.Data
{
    public interface IService<TEntity> where TEntity : class 
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int predicate);
        Task AddAsync(TEntity entity);
        Task RemoveAsync(int predicate);
        Task UpdateAsync(TEntity entity);
    }
}