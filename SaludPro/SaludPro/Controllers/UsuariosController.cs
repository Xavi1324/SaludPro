using Microsoft.AspNetCore.Mvc;
using SaludPro.Core.Application.Interfaces.Services;

namespace SaludPro.Controllers
{
    
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public IActionResult ListUsuarios()
        {
            return View();
        }
    }
}
