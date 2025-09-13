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
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public DateTime fabricacion { get; set; }
        public string numeroMotor { get; set; }
        public string numeroChasis { get; set; }
    }
}
