using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IBaseDal<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
    }
}
