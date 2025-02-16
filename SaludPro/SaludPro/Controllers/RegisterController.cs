using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            //ViewData["Layout"] = null;
            return View();
        }
    }
}
