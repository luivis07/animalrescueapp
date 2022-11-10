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
<<<<<<< HEAD
            var newId = await locationHandler.CreateAsync(locationDto);
=======
            var newId = await locationHandler.Create(locationDto);
>>>>>>> main
            if(newId > 0)
            {
                return RedirectToAction("Details", new { id = newId});
            }
            AddToModelState(validationResult);
            return View(locationCreateVm);
        }
<<<<<<< HEAD
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var locationDto = await locationHandler.GetByIdAsync(id);
            var locationDetailsVm = mapper.Map<LocationDetailsVm?>(locationDto);
            return View(locationDetailsVm);
        }
        [HttpPost]
        public async Task<IActionResult> Details(LocationUpdateVm locationUpdateVm)
        {
            var dto = mapper.Map<LocationDto>(locationUpdateVm);
            var result = await locationHandler.UpdateAsync(dto);
            if(result)
            {
                return RedirectToAction("Details", new { id = locationUpdateVm.Id});
            }
            AddToModelState(validationResult);
            var detailsVm = mapper.Map<LocationDetailsVm>(locationUpdateVm);
            return View(detailsVm);
        }
=======
>>>>>>> main
    }
}