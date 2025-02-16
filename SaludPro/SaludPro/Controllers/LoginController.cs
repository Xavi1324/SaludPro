using Microsoft.AspNetCore.Mvc;

namespace SaludPro.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            //ViewData["Layout"] = null;
            return View();
        }
    }
}
