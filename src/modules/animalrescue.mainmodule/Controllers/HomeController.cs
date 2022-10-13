using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.web
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}