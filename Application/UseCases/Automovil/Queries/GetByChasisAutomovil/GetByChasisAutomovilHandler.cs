using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Application.UseCases.Automovil.Queries.GetByIdAutomovil;
using Core.Application;

namespace Application.UseCases.Automovil.Queries.GetByChasisAutomovil
{
    internal sealed class GetByChasisAutomovilHandler(IAutomovilRepository context) : IRequestQueryHandler<GetByChasisAutomovilQuery, VehiculoDTO>
    {
        private readonly IAutomovilRepository _context = context ?? throw new ArgumentNullException(nameof(context));
        public async Task<VehiculoDTO> Handle(GetByChasisAutomovilQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.Automovil entity = await _context.GetByChasisAsync(request.NumeroChasis) ?? throw new EntityDoesNotExistException();
            return entity.To<VehiculoDTO>();
        }
    }
}
