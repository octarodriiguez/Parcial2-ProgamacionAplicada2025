using System;

namespace Application.DataTransferObjects
{
    public class VehiculoDTO
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime Fabricacion { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
    }
}