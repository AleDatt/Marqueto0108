using Microsoft.AspNetCore.Mvc;

namespace AulaMarqueto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
