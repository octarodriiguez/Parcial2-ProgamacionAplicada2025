using Application.DataTransferObjects;
using Application.Exceptions;
using Application.Repositories;
using Application.UseCases.DummyEntity.Queries.GetDummyEntityBy;
using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Automovil.Queries.GetByIdAutomovil
{
    internal sealed class GetByIdAutomovilHandler(IAutomovilRepository context) : IRequestQueryHandler<GetByIdAutomovilQuery, VehiculoDTO>
    {
        private readonly IAutomovilRepository _context = context ?? throw new ArgumentNullException(nameof(context));
        public async Task<VehiculoDTO> Handle(GetByIdAutomovilQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.Automovil entity = await _context.FindOneAsync(request.Id) ?? throw new EntityDoesNotExistException();
            return entity.To<VehiculoDTO>();
        }
    }
}
