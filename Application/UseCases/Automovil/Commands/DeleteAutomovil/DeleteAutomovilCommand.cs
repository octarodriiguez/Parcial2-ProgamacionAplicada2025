using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Application;
using MediatR;

namespace Application.UseCases.Automovil.Commands.DeleteAutomovil
{
    public class DeleteAutomovilCommand : IRequestCommand<Unit>
    {
        [Required]
        public  string Id { get; set; }
        public DeleteAutomovilCommand()
        {
            
        }
    }
}
