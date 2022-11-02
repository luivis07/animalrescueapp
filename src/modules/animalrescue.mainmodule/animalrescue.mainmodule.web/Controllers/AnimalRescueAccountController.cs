using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.animalrescueaccount;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web
{
    [Route("/[controller]/[action]")]
    public class AnimalRescueAccountController : Controller
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;
        private readonly IMapper mapper;

        public AnimalRescueAccountController(IAnimalRescueAccountHandler animalRescueAccountHandler,IMapper mapper)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var dto = await animalRescueAccountHandler.GetById(id);
            var account = mapper.Map<AnimalRescueAccountDetailsVm>(dto);
            /*TODO: Find out how to properly handle Username not found 
            if(account == null)
            {
                return "ACCOUTN NOT FOUND";
            }
            */
            return View(account);
        }
        [HttpPost]
        public async Task<IActionResult> Update(AnimalRescueAccountUpdateVm animalRescueAccountUpdateVm)
        {
            var dto = mapper.Map<AnimalRescueAccountDto>(animalRescueAccountUpdateVm);
            var result = await animalRescueAccountHandler.Update(dto);
            if (result)
            {
                return RedirectToAction("Details",new{id = dto.Id});
            }
            return View(animalRescueAccountUpdateVm);
        }
    }
}