using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Laboratorio;
using SaludPro.Infrastructure.Persistence.Contexts;

namespace SaludPro.Infrastructure.Persistence.Repositories.Laboratorio
{
    public class ResultadosLabRepository : GenericRepository<ResultadosLaboratorio>, IResultadosLabRepository
    {
        private readonly SaludProContext _dbcontext;
        public ResultadosLabRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }
    }
}
