using SaludPro.Core.Domain.Entities.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Interfaces.Repositories
{
    public interface IPacienteRepository : IGenericRepositoryAsync<Pacientes>
    {
    }
}
