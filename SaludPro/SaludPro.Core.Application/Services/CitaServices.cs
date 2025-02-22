using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Cita;

namespace SaludPro.Core.Application.Services
{
    public class CitaServices : GenericServices<Citas>, ICitaServices
    {
        private readonly ICitaRepository _dbContext;
        public CitaServices(ICitaRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
