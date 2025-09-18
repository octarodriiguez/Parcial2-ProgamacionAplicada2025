using Core.Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IAutomovilRepository : IRepository<Automovil>
    {
        
        // Cambia el tipo de retorno de Task a Task<Automovil>
        Task<Automovil> GetByChasisAsync(string numeroChasis);
        Task<IEnumerable<Automovil>> GetAllAsync();

    }
}