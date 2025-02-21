﻿using SaludPro.Core.Domain.Entities.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Interfaces.Repositories
{
    public interface IPruebasLabRepository : IGenericRepositoryAsync<PruebasLaboratorio>
    {
    }
}
