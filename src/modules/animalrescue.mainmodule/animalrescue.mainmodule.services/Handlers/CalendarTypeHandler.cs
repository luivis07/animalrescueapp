using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.handlers
{
    public class CalendarTypeHandler : BaseHandler, ICalendarTypeHandler
    {
        private readonly ICalendarTypeRepository calendarTypeRepository;
        private readonly IMapper mapper;
        private readonly IValidator<CalendarTypeDto> validator;
        private readonly ValidationResult validationResult;

        public CalendarTypeHandler(ICalendarTypeRepository calendarTypeRepository,
            IMapper mapper,
            IValidator<CalendarTypeDto> validator,
            ValidationResult validationResult)
        {
            this.calendarTypeRepository = calendarTypeRepository;
            this.mapper = mapper;
            this.validator = validator;
            this.validationResult = validationResult;
        }
        public async Task<int> CreateAsync(CalendarTypeDto calendarTypeDto)
        {
            var calendarType = mapper.Map<CalendarType>(calendarTypeDto);
            return await calendarTypeRepository.CreateAsync(calendarType);
        }

        public async Task<IEnumerable<CalendarTypeDto>> GetAllAsync()
        {
            var calendarTypes = await calendarTypeRepository.GetAllAsync();
            return mapper.Map<IEnumerable<CalendarTypeDto>>(calendarTypes);
        }

        public async Task<CalendarTypeDto?> GetByIdAsync(int id)
        {
            var calendarType = await calendarTypeRepository.GetByIdAsync(id);
            return mapper.Map<CalendarTypeDto?>(calendarType);
        }

        public async Task<bool> UpdateAsync(CalendarTypeDto dto)
        {
            var result = validator.Validate(dto);
            if(!result.IsValid)
            {
                mapper.Map(result, validationResult);
                return false;
            }
            var temp = mapper.Map<CalendarType>(dto);
            return await calendarTypeRepository.UpdateAsync(temp, dto.ChangedProperties.ToList());
        }
    }
}