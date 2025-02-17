using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult ListUsuarios()
        {
            return View();
        }
    }
}
