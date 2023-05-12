using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Entityframework
{
    public class EfBaseDal<TEntity, TContext> : EfBaseRepository<TEntity, TContext>, IBaseDal<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : WebAPIContext, new()
    {
    }
}
