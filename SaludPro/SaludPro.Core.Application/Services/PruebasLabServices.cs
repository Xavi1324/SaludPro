using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Services
{
    public class PruebasLabServices : GenericServices<PruebasLaboratorio>, IPuebasLabServices
    {
        private readonly IPruebasLabRepository _dbContext;
        public PruebasLabServices(IPruebasLabRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
