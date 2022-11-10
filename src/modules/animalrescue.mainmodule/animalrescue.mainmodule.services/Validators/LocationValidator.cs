using animalrescue.mainmodule.services.dtos;
using FluentValidation;

namespace animalrescue.mainmodule.services.validators
{
    public class LocationValidator : AbstractValidator<LocationDto>
    {
        public LocationValidator()
        {
            RuleFor(l => l.Id).GreaterThan(0);
            RuleFor(l => l.Name).NotNull().NotEmpty();
        }
    }
}