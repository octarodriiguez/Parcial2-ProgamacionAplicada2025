using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Automovil.Commands.CreateAutomovil
{
    public class CreateAutomovilCommand : IRequestCommand<string>
    {
        
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        
        
    }
}
