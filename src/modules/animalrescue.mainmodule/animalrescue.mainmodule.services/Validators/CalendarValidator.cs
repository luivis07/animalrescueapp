using animalrescue.mainmodule.services.dtos;
using FluentValidation;

namespace animalrescue.mainmodule.services.validators
{
    public class CalendarValidator : AbstractValidator<CalendarDto>
    {
        public CalendarValidator()
        {
            RuleFor(c => c.Id).GreaterThan(0);
            RuleFor(c => c.CalendarTypeId).GreaterThan(0);
            RuleFor(c => c.LocationId).GreaterThan(0);
        }
    }
}