using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Laboratorio;
using SaludPro.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence.Repositories.Laboratorio
{
    public class PruebasLabRepository : GenericRepository<PruebasLaboratorio>, IPruebasLabRepository
    {
        private readonly SaludProContext _dbcontext;
        public PruebasLabRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
