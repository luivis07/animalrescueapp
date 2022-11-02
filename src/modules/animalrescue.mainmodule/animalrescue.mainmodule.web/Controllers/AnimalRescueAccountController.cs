using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.animalrescueaccount;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Users;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web
{
    [Authorize]
    [Route("/[controller]/[action]")]
    public class AnimalRescueAccountController : Controller
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;
        private readonly IMapper mapper;
        private readonly UserManager<IUser> userManager;

        public AnimalRescueAccountController(IAnimalRescueAccountHandler animalRescueAccountHandler,
            IMapper mapper,
            UserManager<IUser> userManager)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var user = await userManager.GetUserAsync(this.User);
            var dto = await animalRescueAccountHandler.GetByUsernameAsync(user.UserName);
            var account = mapper.Map<AnimalRescueAccountDetailsVm>(dto);
            return View(account);
        }
        [HttpPost]
        public async Task<IActionResult> Update(AnimalRescueAccountUpdateVm animalRescueAccountUpdateVm)
        {
            var dto = mapper.Map<AnimalRescueAccountDto>(animalRescueAccountUpdateVm);
            var result = await animalRescueAccountHandler.UpdateAsync(dto);
            if (result)
            {
                return RedirectToAction("Details");
            }
            return View(animalRescueAccountUpdateVm);
        }
    }
}