using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Paciente;
using SaludPro.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence.Repositories.Paciente
{
    public class PacienteRepository : GenericRepository<Pacientes>, IPacienteRepository
    {
        private readonly SaludProContext _dbcontext;
        public PacienteRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
