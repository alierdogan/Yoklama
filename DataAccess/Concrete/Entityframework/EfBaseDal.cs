using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Abstract;

namespace DataAccess.Concrete.Entityframework
{
    public class EfBaseDal<TEntity, TContext> : EfBaseRepository<TEntity, TContext>, IBaseDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : YoklamaContext, new()
    {
    }
}
