using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.web
{
    [Route("/[controller]/[action]")]
    public class HomeController : Controller
    {        
        [Route("/")]
        [Route("/home")]
        [Route("/home/index")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Sponsors()
        {
            return View();
        }
    }
}