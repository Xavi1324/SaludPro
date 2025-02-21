using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class PacientesController : Controller
    {
        public IActionResult ListPacientes()
        {
            return View();
        }
    }
}
