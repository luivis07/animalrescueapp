using animalrescue.mainmodule.services.handlers.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web.controllers
{
    public class VolunteerApplicationController : BaseController
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