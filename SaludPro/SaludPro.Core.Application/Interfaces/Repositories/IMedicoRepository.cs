using SaludPro.Core.Domain.Entities.Medico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Interfaces.Repositories
{
    public interface IMedicoRepository : IGenericRepositoryAsync<Medicos>
    {
    }
}
