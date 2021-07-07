using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        IMongoCollection<TEntity> IMongoDBContext.GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
