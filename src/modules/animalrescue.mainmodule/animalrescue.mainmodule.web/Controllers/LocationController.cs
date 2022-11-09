using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.location;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace animalrescue.mainmodule.web.controllers
{
    [Authorize]
    public class LocationController : BaseController
    {
        private readonly ILocationHandler locationHandler;
        private readonly IMapper mapper;
        private readonly ValidationResult validationResult;

        public LocationController(ILocationHandler locationHandler,
            IMapper mapper,
            ValidationResult validationResult)
        {
            this.locationHandler = locationHandler;
            this.mapper = mapper;
            this.validationResult = validationResult;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LocationCreateVm locationCreateVm)
        {
            var locationDto = mapper.Map<LocationDto>(locationCreateVm);
            var newId = await locationHandler.Create(locationDto);
            if(newId > 0)
            {
                return RedirectToAction("Details", new { id = newId});
            }
            AddToModelState(validationResult);
            return View(locationCreateVm);
        }
    }
}