using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Medico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Services
{
    public class MedicoServices : GenericServices<Medicos>, IMedicoServices
    {
        private readonly IMedicoRepository _dbContext;
        public MedicoServices(IMedicoRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
