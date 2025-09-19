using Application.DataTransferObjects;
using Application.DomainEvents;
using Application.UseCases.Automovil.Commands.CreateAutomovil;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    /// <summary>
    /// El mapeo entre objetos debe ir definido aqui
    /// </summary>
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<DummyEntity, DummyEntityCreated>().ReverseMap();
            CreateMap<DummyEntity, UpdateAutomovil>().ReverseMap();
            CreateMap<DummyEntity, DummyEntityDto>().ReverseMap();
            CreateMap<Domain.Entities.Automovil, VehiculoDTO>();
            CreateMap<CreateAutomovilCommand, Automovil>();
        }
    }
}
