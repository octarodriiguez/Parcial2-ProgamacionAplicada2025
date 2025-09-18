using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationServices.AutomovilServices
{
    public class AutomovilApplicationService(IAutomovilRepository context) : IAutomovilAplicationService
    {
        private readonly IAutomovilRepository _context = context ?? throw new ArgumentNullException(nameof(context));

        public bool Automovil(object value)
        {
            throw new NotImplementedException();
        }

        
    }
}
