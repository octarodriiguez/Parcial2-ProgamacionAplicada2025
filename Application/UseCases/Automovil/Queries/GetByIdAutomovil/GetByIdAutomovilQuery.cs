using Application.DataTransferObjects;
using Core.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Automovil.Queries.GetByIdAutomovil
{
    public class GetByIdAutomovilQuery: IRequestQuery<VehiculoDTO>
    {

        [Required]
        public string Id { get; set; }

        public GetByIdAutomovilQuery()
        {
            
        }

    }
}
