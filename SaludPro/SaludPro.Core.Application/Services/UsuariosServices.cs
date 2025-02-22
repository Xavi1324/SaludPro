using SaludPro.Core.Application.Interfaces.Repositories;
using SaludPro.Core.Application.Interfaces.Services;
using SaludPro.Core.Application.ViewModel.Usuario;
using SaludPro.Core.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludPro.Core.Application.Services
{
    public class UsuariosServices : GenericServices<Usuarios>, IUsuarioService
    {
        private readonly IUsuarioRepository _dbContext;
        public UsuariosServices(IUsuarioRepository dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

     
    }
    
}
