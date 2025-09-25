using Core.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DomainEvents.Vehiculo
{
    internal sealed class UpdateAutomovil : DomainEvent
    {
        [Required]
        public string Id { get; set; }
        public string Color { get; set; }
        public string NumeroMotor { get; set; }
    }
}
