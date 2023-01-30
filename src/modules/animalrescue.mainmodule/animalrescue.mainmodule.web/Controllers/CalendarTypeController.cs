using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.calendartype;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace animalrescue.mainmodule.web.controllers
{
    [Authorize]
    public class CalendarTypeController : BaseController
    {
        private readonly ICalendarTypeHandler calendarTypeHandler;
        private readonly IMapper mapper;
        private readonly ValidationResult validationResult;

        public CalendarTypeController(ICalendarTypeHandler calendarTypeHandler,
            IMapper mapper,
            ValidationResult validationResult)
        {
            this.calendarTypeHandler = calendarTypeHandler;
            this.mapper = mapper;
            this.validationResult = validationResult;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CalendarTypeCreateVm calendarTypeCreateVm)
        {
            var calendarTypeDto = mapper.Map<CalendarTypeDto>(calendarTypeCreateVm);
            var newId = await calendarTypeHandler.CreateAsync(calendarTypeDto);
            if(newId > 0)
            {
                return RedirectToAction("Details", new { id = newId});
            }
            AddToModelState(validationResult);
            return View(calendarTypeCreateVm);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var calendarTypeDto = await calendarTypeHandler.GetByIdAsync(id);
            var calendarTypeDetailsVm = mapper.Map<CalendarTypeDetailsVm?>(calendarTypeDto);
            return View(calendarTypeDetailsVm);
        }
        [HttpPost]
        public async Task<IActionResult> Details(CalendarTypeUpdateVm calendarTypeUpdateVm)
        {
            var dto = mapper.Map<CalendarTypeDto>(calendarTypeUpdateVm);
            var result = await calendarTypeHandler.UpdateAsync(dto);
            if(result)
            {
                return RedirectToAction("Details", new {id = calendarTypeUpdateVm.Id});
            }
            AddToModelState(validationResult);
            var detailsVm = mapper.Map<CalendarTypeDetailsVm>(calendarTypeUpdateVm);
            return View(detailsVm);
        }
    }
}