using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Cita;
using SaludPro.Infrastructure.Persistence.Contexts;

namespace SaludPro.Infrastructure.Persistence.Repositories.Cita
{
    public class CitaRepository : GenericRepository<Citas>, ICitaRepository
    {
        private readonly SaludProContext _dbcontext;
        public CitaRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
