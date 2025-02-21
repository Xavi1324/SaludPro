using SaludPro.Core.Domain.Entities.Cita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Interfaces.Repositories
{
    public interface ICitaRepository : IGenericRepositoryAsync<Citas>
    {
    }
}
