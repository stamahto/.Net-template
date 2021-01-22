using PROJECT.Data;
using PROJECT.Entities;
using PROJECT.Repositories.Base;
using PROJECT.Repositories.Interfaces;

namespace PROJECT.Repositories
{
    public class Repository : RepositoryBase<ENTITY>, IRepository
    {
        public Repository(CONTEXT context) : base(context)
        {
        }
    }
}
