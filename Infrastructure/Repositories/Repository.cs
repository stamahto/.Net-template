using PROJECT.Data;
using PROJECT.Entities;
using PROJECT.Infrastructure.Repositories.Base;
using PROJECT.Infrastructure.Repositories.Interfaces;;

namespace PROJECT.Infrastructure.Repositories
{
    public class Repository : RepositoryBase<ENTITY>, IRepository
    {
        public Repository(CONTEXT context) : base(context)
        {
        }
    }
}
