using animalrescue.mainmodule.services.dtos;
using FluentValidation;

public class AnimalRescueAccountValidator : AbstractValidator<AnimalRescueAccountDto>
{
    public AnimalRescueAccountValidator()
    {   
        RuleFor(ara => ara.Id).GreaterThan(0);
        RuleFor(ara => ara.FirstName).NotEmpty();
        RuleFor(ara => ara.LastName).NotEmpty();
    }
}