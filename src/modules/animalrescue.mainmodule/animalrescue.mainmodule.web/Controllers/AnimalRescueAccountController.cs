using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.animalrescueaccount;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Users;
using System.Threading.Tasks;

namespace animalrescue.mainmodule.web.controllers
{
    [Authorize]
    public class AnimalRescueAccountController : BaseController
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;
        private readonly IMapper mapper;
        private readonly UserManager<IUser> userManager;
        private readonly ValidationResult validationResult;

        public AnimalRescueAccountController(IAnimalRescueAccountHandler animalRescueAccountHandler,
            IMapper mapper,
            UserManager<IUser> userManager,
            ValidationResult validationResult)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
            this.mapper = mapper;
            this.userManager = userManager;
            this.validationResult = validationResult;
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
        public async Task<IActionResult> Details(AnimalRescueAccountUpdateVm animalRescueAccountUpdateVm)
        {
            var dto = mapper.Map<AnimalRescueAccountDto>(animalRescueAccountUpdateVm);
            var result = await animalRescueAccountHandler.UpdateAsync(dto);
            if (result)
            {
                return RedirectToAction("Details");
            }
            AddToModelState(validationResult);
            var detailsVm = mapper.Map<AnimalRescueAccountDetailsVm>(animalRescueAccountUpdateVm);
            return View(detailsVm);
        }
    }
}