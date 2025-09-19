using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DataTransferObjects;
using Core.Application;

namespace Application.UseCases.Automovil.Queries.GetByChasisAutomovil
{
    public class GetByChasisAutomovilQuery : IRequestQuery<VehiculoDTO>
    {
        [Required]
        public string NumeroChasis { get; set; }

        public GetByChasisAutomovilQuery()
        {
            
        }
    }

    
}
