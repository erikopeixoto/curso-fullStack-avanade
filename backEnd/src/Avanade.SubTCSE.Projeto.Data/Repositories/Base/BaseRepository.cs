using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId>
        : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _collection;
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public virtual Task<TEntity> FindById(TId id)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<List<TEntity>> List(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
