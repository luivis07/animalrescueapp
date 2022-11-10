using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using animalrescue.mainmodule.web.viewmodels.calendar;
using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace animalrescue.mainmodule.web.controllers
{
    [Authorize]
    public class CalendarController : BaseController
    {
        private readonly ICalendarHandler calendarHandler;
        protected readonly ICalendarTypeHandler calendarTypeHandler;
        protected readonly ILocationHandler locationHandler;
        private readonly IMapper mapper;
        private readonly ValidationResult validationResult;

        public CalendarController(ICalendarHandler calendarHandler,
            ICalendarTypeHandler calendarTypeHandler,
            ILocationHandler locationHandler,
            IMapper mapper,
            ValidationResult validationResult)
        {
            this.calendarHandler = calendarHandler;
            this.calendarTypeHandler = calendarTypeHandler;
            this.locationHandler = locationHandler;
            this.mapper = mapper;
            this.validationResult = validationResult;
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var calendarCreateVm = new CalendarCreateVm();
            calendarCreateVm.CalendarTypes = await calendarTypeHandler.GetAllAsync();
            calendarCreateVm.Locations = await locationHandler.GetAllAsync();
            return View(calendarCreateVm);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CalendarCreateVm calendarCreateVm)
        {
            var calendarDto = mapper.Map<CalendarDto>(calendarCreateVm);
            var newId = await calendarHandler.CreateAsync(calendarDto);
            if (newId > 0)
            {
                return RedirectToAction("Details", new { id = newId });
            }
            AddToModelState(validationResult);
            calendarCreateVm.CalendarTypes = await calendarTypeHandler.GetAllAsync();
            calendarCreateVm.Locations = await locationHandler.GetAllAsync();
            return View(calendarCreateVm);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var calendarDto = await calendarHandler.GetByIdAsync(id);
            var calendarDetailsVm = mapper.Map<CalendarDetailsVm?>(calendarDto);
            // TODO: need to create NOTFOUND view
            if (calendarDetailsVm != null)
            {
                calendarDetailsVm.CalendarTypes = await calendarTypeHandler.GetAllAsync();
                calendarDetailsVm.Locations = await locationHandler.GetAllAsync();
            }
            return View(calendarDetailsVm);
        }
        [HttpPost]
        public async Task<IActionResult> Details(CalendarUpdateVm calendarUpdateVm)
        {
            var dto = mapper.Map<CalendarDto>(calendarUpdateVm);
            var result = await calendarHandler.UpdateAsync(dto);
            if (result)
            {
                return RedirectToAction("Details", new { id = calendarUpdateVm.Id });
            }
            AddToModelState(validationResult);
            var detailsVm = mapper.Map<CalendarDetailsVm>(calendarUpdateVm);
            detailsVm.CalendarTypes = await calendarTypeHandler.GetAllAsync();
            detailsVm.Locations = await locationHandler.GetAllAsync();
            return View(detailsVm);
        }
    }
}