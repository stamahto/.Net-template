using PROJECT.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly CONTEXT _context;

        public RepositoryBase(CONTEXT context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            _context.Set<T>().AddRange(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<T> entity)
        {
            _context.Set<T>().UpdateRange(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _context.Set<T>().RemoveRange(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Set<T>().Any(e => e.Id == id);
        }
    }
}
