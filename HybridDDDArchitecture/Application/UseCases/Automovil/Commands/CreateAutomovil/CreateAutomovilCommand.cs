using Core.Application;
using System.ComponentModel.DataAnnotations;

namespace Application.UseCases.Automovil.Commands.CreateAutomovil
{
    public class CreateAutomovilCommand : IRequestCommand<string>
    {
        [Required]
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime Fabricacion { get; set; }
        [Required]
        public string NumeroMotor { get; set; }
        [Required]
        public string NumeroChasis { get; set; }
    }
}