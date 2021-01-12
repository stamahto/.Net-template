using PROJECT.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PROJECT.Repositories.Base
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<IEnumerable<T>> ToListAsync();
        Task<T> FindAsync(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        Task SaveChangesAsync();
        bool Exists(int id);
    }
}
