using Core.Domain.Entities;
using Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Automovil : DomainEntity<string, AutomovilEntityValidator>
    {
        
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime Fabricacion { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
    }
}
