using animalrescue.mainmodule.services.dtos;
using FluentValidation;

namespace animalrescue.mainmodule.services.validators
{
    public class CalendarTypeValidator : AbstractValidator<CalendarTypeDto>
    {
        public CalendarTypeValidator()
        {
            RuleFor(ct => ct.Id).GreaterThan(0);
            RuleFor(ct => ct.Name).NotNull().NotEmpty();
        }
    }
}