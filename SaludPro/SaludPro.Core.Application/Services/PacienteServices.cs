using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Paciente;

namespace SaludPro.Core.Application.Services
{
    public class PacienteServices : GenericServices<Pacientes>, IPacienteServices
    {
        private readonly IPacienteRepository _dbContext;
        public PacienteServices(IPacienteRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
