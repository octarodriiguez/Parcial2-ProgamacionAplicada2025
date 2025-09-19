using Core.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.Enums;

namespace Application.UseCases.Automovil.Commands.UpdateAutomovil
{
    public class UpdateAutomovilCommand: IRequestCommand
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string color { get; set; }
        public string numeroMotor { get; set; }

        public UpdateAutomovilCommand()
        {
            
        }

    }
}
