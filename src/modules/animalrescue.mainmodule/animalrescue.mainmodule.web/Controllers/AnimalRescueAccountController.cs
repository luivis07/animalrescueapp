using animalrescue.mainmodule.services.handlers.interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web
{
    [Route("/[controller]/[action]")]
    public class AnimalRescueAccountController : Controller
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;

        public AnimalRescueAccountController(IAnimalRescueAccountHandler animalRescueAccountHandler)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
        }

        public async Task<IActionResult> Details(string username)
        {
            var account = await animalRescueAccountHandler.GetAnimalRescueAccountByUsername(username);
            /*TODO: Find out how to properly handle Username not found 
            if(account == null)
            {
                return "ACCOUTN NOT FOUND";
            }
            */
            return View(account);
        }
    }
}