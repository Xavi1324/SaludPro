using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Medico;
using SaludPro.Core.Domain.Entities.Usuario;
using SaludPro.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence.Repositories.Medico
{
    public class MedicoRepository : GenericRepository<Medicos>, IMedicoRepository
    {
        private readonly SaludProContext _dbcontext;
        public MedicoRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
