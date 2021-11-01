using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}