using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Domain.Entities.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Services
{
    public class ResultadosLabServices : GenericServices<ResultadosLaboratorio>, IResultadosLabServices
    {
        private readonly IResultadosLabRepository _dbContext;
        public ResultadosLabServices(IResultadosLabRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
