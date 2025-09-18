using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Application;

namespace Application.DomainEvents.Vehiculo
{
    internal sealed class AutomovilDelete : DomainEvent
    {
        public string Id { get; set; }
        public AutomovilDelete(string id)
        {
            Id = id;
        }
    }
}
