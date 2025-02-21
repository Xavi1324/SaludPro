using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Consultorio;
using SaludPro.Core.Domain.Entities.Laboratorio;
using SaludPro.Infrastructure.Persistence.Contexts;
using SaludPro.Infrastructure.Persistence.Repositories.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence.Repositories.Consultorio
{
    public class ConsultorioRepository : GenericRepository<Consultorios>, IConsultorioRepository
    {
        private readonly SaludProContext _dbcontext;
        public ConsultorioRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
