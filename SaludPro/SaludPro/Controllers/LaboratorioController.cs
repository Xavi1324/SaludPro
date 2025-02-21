using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class LaboratorioController : Controller
    {
        public IActionResult ListPuebasLab()
        {
            return View();
        }

        public IActionResult ListResultadosLab()
        {
            return View();
        }
    }
}
