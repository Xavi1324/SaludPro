using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class MedicosController : Controller
    {
        public IActionResult ListMedicos()
        {
            return View();
        }
    }
}
