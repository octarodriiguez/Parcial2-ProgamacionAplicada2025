using Application.Repositories;
using Core.Infraestructure.Repositories.Sql;
using Domain.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Repositories.Sql
{
    internal sealed class AutomovilRepository(StoreDbContext context) : BaseRepository<Automovil>(context), IAutomovilRepository

    {
        public object Add(DummyEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> AddAsync(DummyEntity entity)
        {
            throw new NotImplementedException();
        }

        public long Count(Expression<Func<DummyEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<long> CountAsync(Expression<Func<DummyEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<DummyEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<DummyEntity>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public DummyEntity FindOne(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<DummyEntity> FindOneAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Automovil>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Automovil> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(object id, DummyEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
