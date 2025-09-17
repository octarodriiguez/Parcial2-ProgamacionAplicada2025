using Application.Repositories;
using Core.Infraestructure.Repositories.Sql;
using Domain.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Repositories.Sql
{
    internal sealed class AutomovilRepository(StoreDbContext context) : BaseRepository<Automovil>(context), IAutomovilRepository

    {
        public Task<IEnumerable<Automovil>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Automovil> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
