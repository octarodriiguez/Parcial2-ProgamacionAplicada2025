using Core.Domain.Entities;
using Domain.Validators;
using System;

namespace Domain.Entities
{
    public class Automovil : DomainEntity<string, AutomovilEntityValidator>
    {
        public Automovil(string marca, string modelo, string color, DateTime fabricacion, string numeroMotor, string numeroChasis)
        {
            Id = Guid.NewGuid().ToString(); // Se genera el ID en el constructor
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Fabricacion = fabricacion;
            NumeroMotor = numeroMotor;
            NumeroChasis = numeroChasis;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime Fabricacion { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
    }
}