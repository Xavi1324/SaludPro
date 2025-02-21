using Microsoft.EntityFrameworkCore;
using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Domain.Entities.Usuario;
using SaludPro.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Infrastructure.Persistence.Repositories.Usuario
{
    public class UsuarioRepository : GenericRepository<Usuarios>, IUsuarioRepository
    {
        private readonly SaludProContext _dbContext;
        public UsuarioRepository(SaludProContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
