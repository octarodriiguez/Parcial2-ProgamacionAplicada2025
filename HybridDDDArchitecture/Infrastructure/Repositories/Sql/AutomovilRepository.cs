using Application.Repositories;
using Core.Infraestructure.Repositories.Sql;
using Domain.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Sql
{
    internal sealed class AutomovilRepository(StoreDbContext _context) : BaseRepository<Automovil>(_context), IAutomovilRepository
    {
        // Ya no necesitas el método AddAsync aquí, ya que el BaseRepository lo implementa

        public async Task<IEnumerable<Automovil>> GetAllAsync()
        {
            return await _context.Set<Automovil>().ToListAsync();
        }

        public async Task<Automovil> GetByChasisAsync(string numeroChasis)
        {
            return await _context.Set<Automovil>().FirstOrDefaultAsync(a => a.NumeroChasis == numeroChasis);
        }

        public async Task<Automovil> GetByIdAsync(string id)
        {
            return await _context.Set<Automovil>().FindAsync(id);
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        
    }
}