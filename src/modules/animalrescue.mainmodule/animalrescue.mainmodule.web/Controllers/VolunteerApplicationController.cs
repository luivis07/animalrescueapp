using animalrescue.mainmodule.services.handlers.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web
{
    [Route("/[controller]/[action]")]
    public class VolunteerApplicationController : Controller
    {
        private readonly IVolunteerApplicationHandler volunteerApplicationHandler;

        public VolunteerApplicationController(IVolunteerApplicationHandler volunteerApplicationHandler)
        {
            this.volunteerApplicationHandler = volunteerApplicationHandler;
        }

        public IActionResult List()
        {
            var records = volunteerApplicationHandler.GetVolunteerApplications();
            return View();
        }
    }
}