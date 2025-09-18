using Application.DataTransferObjects;
using Application.Repositories;
using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Application.Exceptions;

namespace Application.UseCases.Automovil.Queries.GetAllAutomovil
{
    internal class GetAllAutomovilHandler(IAutomovilRepository automovilRepository, IMapper mapper) : IRequestQueryHandler<GetAllAutomovilQuery, QueryResult<VehiculoDTO>>
    {
        private readonly IAutomovilRepository _automovilRepository = automovilRepository ?? throw new ArgumentNullException(nameof(automovilRepository));
        private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        public async Task<QueryResult<VehiculoDTO>> Handle(GetAllAutomovilQuery request, CancellationToken cancellationToken)
        {
            // Validar que los parámetros de paginación sean válidos
            if (request.PageSize <= 0)
            {
                throw new BussinessException("Page size must be greater than zero.");
            }

            // Obtenemos todas las entidades
            var allEntities = (await _automovilRepository.GetAllAsync()).ToList();

            // Paginamos la lista en memoria
            var pagedEntities = allEntities
                .Skip((int)(request.PageIndex - 1) * (int)request.PageSize)
                .Take((int)request.PageSize)
                .ToList();

            // Mapeamos las entidades paginadas a DTOs
            IList<VehiculoDTO> dtoList = _mapper.Map<IList<VehiculoDTO>>(pagedEntities);

            // Devolvemos los resultados paginados en un QueryResult
            return new QueryResult<VehiculoDTO>(
                dtoList,
                allEntities.Count(),
                request.PageIndex,
                request.PageSize);
        }
    }
}