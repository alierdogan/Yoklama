using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IBaseDal<TEntity> _dal;
        public Service(IBaseDal<TEntity> dal)
        {
            _dal = dal;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            return await _dal.AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return await _dal.AddRangeAsync(entities);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _dal.DeleteAsync(id);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dal.GetAsync(filter);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dal.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _dal.GetListAsync(filter);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _dal.UpdateAsync(entity);
        }
    }
}
