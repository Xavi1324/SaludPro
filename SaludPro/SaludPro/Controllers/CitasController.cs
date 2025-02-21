using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class CitasController : Controller
    {
        public IActionResult ListCitas()
        {
            return View();
        }
    }
}
