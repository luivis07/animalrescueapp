using animalrescue.mainmodule.services.dtos;
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
        [HttpGet]
        public async Task<IActionResult> Details(string username)
        {
            var account = await animalRescueAccountHandler.GetByUsername(username);
            /*TODO: Find out how to properly handle Username not found 
            if(account == null)
            {
                return "ACCOUTN NOT FOUND";
            }
            */
            return View(account);
        }
        [HttpPost]
        public async Task<IActionResult> Update(AnimalRescueAccountDto animalRescueAccountDto)
        {
            var result = await animalRescueAccountHandler.Update(animalRescueAccountDto);
            if (result)
            {
                return RedirectToAction("Details",new{username = animalRescueAccountDto.Username});
            }
            return View(animalRescueAccountDto);
        }
    }
}