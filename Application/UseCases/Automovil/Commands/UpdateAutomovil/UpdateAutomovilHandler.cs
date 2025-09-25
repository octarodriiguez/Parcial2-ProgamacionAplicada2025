using Application.Constants;
using Application.DomainEvents;
using Application.Exceptions;
using Application.Repositories;
using Application.DomainEvents.Vehiculo;
using Application.UseCases.DummyEntity.Commands.UpdateDummyEntity;
using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Automovil.Commands.UpdateAutomovil
{
    internal sealed class UpdateAutomovilHandler(ICommandQueryBus domainBus, IAutomovilRepository automovilRepository) : IRequestCommandHandler<UpdateAutomovilCommand>
    {
        private readonly ICommandQueryBus _domainBus = domainBus ?? throw new ArgumentNullException(nameof(domainBus));
        private readonly IAutomovilRepository _context = automovilRepository ?? throw new ArgumentNullException(nameof(automovilRepository));

        public async Task Handle(UpdateAutomovilCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Automovil entity = await _context.FindOneAsync(request.Id) ?? throw new EntityDoesNotExistException();
            entity.setColor(request.color);
            entity.setNumeroMotor(request.numeroMotor);

            try
            {
                _context.Update(request.Id, entity);

                await _domainBus.Publish(entity.To<DomainEvents.Vehiculo.UpdateAutomovil>(), cancellationToken);
            }
            catch (Exception ex)
            {
                throw new BussinessException(ApplicationConstants.PROCESS_EXECUTION_EXCEPTION, ex.InnerException);
            }
        }
    }
}
