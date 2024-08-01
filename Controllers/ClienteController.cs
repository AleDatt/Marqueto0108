using Microsoft.AspNetCore.Mvc;

namespace AulaMarqueto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
