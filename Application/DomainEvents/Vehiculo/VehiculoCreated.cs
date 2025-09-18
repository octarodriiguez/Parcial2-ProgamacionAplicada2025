using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainEvents.Vehiculo
{
    internal sealed class VehiculoCreated : DomainEvent
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
    }
}
