using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web.controllers
{
    public class HomeController : BaseController
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
        public IActionResult Leadership()
        {
            return View();
        }
    }
}