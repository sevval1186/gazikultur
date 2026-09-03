using Microsoft.AspNetCore.Mvc;

namespace GaziKultur.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

