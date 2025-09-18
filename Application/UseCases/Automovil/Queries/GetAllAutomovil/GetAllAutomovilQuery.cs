using Application.DataTransferObjects;
using Core.Application;

namespace Application.UseCases.Automovil.Queries.GetAllAutomovil
{
    public class GetAllAutomovilQuery : QueryRequest<QueryResult<VehiculoDTO>>
    {
        // Agregamos las propiedades para la paginación
        public uint PageIndex { get; set; } = 1;
        public uint PageSize { get; set; } = 10;
    }
}