using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Consultorio;

namespace SaludPro.Core.Application.Services
{
    public class ConsultorioServices : GenericServices<Consultorios>, IConsultorioServices
    {
        private readonly IConsultorioRepository _dbContext;
        public ConsultorioServices(IConsultorioRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
