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
            return Redirect("/home-page");
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
        public IActionResult Donate()
        {
            return View();
        }
    }
}