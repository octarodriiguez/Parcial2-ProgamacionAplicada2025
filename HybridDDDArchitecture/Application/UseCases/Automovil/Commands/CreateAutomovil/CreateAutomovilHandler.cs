using Application.Constants;
using Application.DomainEvents.Vehiculo;
using Application.Exceptions;
using Application.Repositories;
using Core.Application;
using AutoMapper;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.UseCases.Automovil.Commands.CreateAutomovil
{
    // Aseguramos que se inyecte IMapper para que el mapeo funcione
    internal sealed class CreateAutomovilHandler(
        ICommandQueryBus domainBus,
        IAutomovilRepository automovilRepository,
        IMapper mapper) : IRequestCommandHandler<CreateAutomovilCommand, string>
    {
        private readonly ICommandQueryBus _domainBus = domainBus ?? throw new ArgumentNullException(nameof(domainBus));
        private readonly IAutomovilRepository _automovilRepository = automovilRepository ?? throw new ArgumentNullException(nameof(automovilRepository));
        private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        public async Task<string> Handle(CreateAutomovilCommand request, CancellationToken cancellationToken)
        {
            // Generamos los valores únicos aquí, en la lógica de negocio.
            string numeroMotorGenerado = GenerarNumeroMotor();
            string numeroChasisGenerado = GenerarNumeroChasis();
            DateTime fechaFabricacion = DateTime.Now;

            // Validamos que el NumeroChasis sea único en la base de datos
            if (await _automovilRepository.GetByChasisAsync(numeroChasisGenerado) != null)
            {
                throw new EntityDoesExistException("Ya existe un automóvil con ese número de chasis.");
            }

            try
            {
                // Creamos la entidad pasándole TODOS los valores.
                Domain.Entities.Automovil entity = new(
                    request.Marca,
                    request.Modelo,
                    request.Color,
                    fechaFabricacion,
                    numeroMotorGenerado,
                    numeroChasisGenerado
                );

                if (!entity.IsValid) throw new InvalidEntityDataException(entity.GetErrors());

                string createdId = (string)await _automovilRepository.AddAsync(entity);

                await _domainBus.Publish(entity.To<VehiculoCreated>(), cancellationToken);

                return createdId;
            }
            catch (Exception ex)
            {
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex.InnerException);
            }
        }

        // --- LOS MÉTODOS DEBEN ESTAR AQUÍ DENTRO DE LA CLASE ---

        // Método para generar un número de motor (ejemplo simplificado)
        private string GenerarNumeroMotor() => Guid.NewGuid().ToString().Substring(0, 10).ToUpper();

        // Método para generar un número de chasis (ejemplo simplificado)
        private string GenerarNumeroChasis()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var chasis = new char[17];
            for (int i = 0; i < chasis.Length; i++)
            {
                chasis[i] = caracteres[random.Next(caracteres.Length)];
            }
            return new string(chasis);
        }
    }
}