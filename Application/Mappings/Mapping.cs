using Application.DataTransferObjects;
using Application.DomainEvents;
using Application.DomainEvents.Vehiculo;
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
            //Obtener solo YYYY
            CreateMap<Domain.Entities.Automovil, VehiculoDTO>()
                .ForMember(dest => dest.Fabricacion, opt => opt.MapFrom(src => src.Fabricacion.Year));

            CreateMap<CreateAutomovilCommand, Automovil>();

            CreateMap<Automovil, VehiculoCreated>(); ;
        }
    }
}
