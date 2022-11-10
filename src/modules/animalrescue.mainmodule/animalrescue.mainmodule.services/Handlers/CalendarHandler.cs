using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.handlers
{
    public class CalendarHandler : BaseHandler, ICalendarHandler
    {
        private readonly ICalendarRepository calendarRepository;
        private readonly IMapper mapper;
        private readonly IValidator<CalendarDto> validator;
        private readonly ValidationResult validationResult;

        public CalendarHandler(ICalendarRepository calendarRepository,
            IMapper mapper,
            IValidator<CalendarDto> validator,
            ValidationResult validationResult)
        {
            this.calendarRepository = calendarRepository;
            this.mapper = mapper;
            this.validator = validator;
            this.validationResult = validationResult;
        }
        public async Task<int> CreateAsync(CalendarDto calendarDto)
        {
            var calendar = mapper.Map<Calendar>(calendarDto);
            return await calendarRepository.CreateAsync(calendar);
        }

        public async Task<CalendarDto?> GetByIdAsync(int id)
        {
            var calendar = await calendarRepository.GetByIdAsync(id);
            return mapper.Map<CalendarDto?>(calendar);
        }

        public async Task<bool> UpdateAsync(CalendarDto dto)
        {
            var result = validator.Validate(dto);
            if(!result.IsValid)
            {
                mapper.Map(result, validationResult);
                return false;
            }
            var temp = mapper.Map<Calendar>(dto);
            return await calendarRepository.UpdateAsync(temp, dto.ChangedProperties.ToList());
        }
    }
}