using animalrescue.mainmodule.services.dtos;
using FluentValidation;

public class AnimalRescueAccountValidator : AbstractValidator<AnimalRescueAccountDto>
{
    public AnimalRescueAccountValidator()
    {
        RuleFor(ara => ara.Id).NotNull();
        RuleFor(ara => ara.Username).NotNull();
        RuleFor(ara => ara.FirstName).Length(1, 150);
        RuleFor(ara => ara.LastName).Length(1, 150);
        RuleFor(ara => ara.EmailAddress).EmailAddress();
        RuleFor(ara => ara.PhoneNumber).Length(1, 150);
        RuleFor(ara => ara.Address1).Length(1, 100);
        RuleFor(ara => ara.Address2).Length(1, 60);
        RuleFor(ara => ara.City).Length(1, 60);
        RuleFor(ara => ara.State).Length(1, 50);
        RuleFor(ara => ara.ZipCode).Length(1, 10);
        RuleFor(ara => ara.Country).Length(1, 55);
        RuleFor(ara => ara.DateOfBirth).Must(BeAValidAge);
    }
    protected bool BeAValidAge(DateTime? date)
    {
        if (date == null)
        {
            return false;
        }
        int currentYear = DateTime.Now.Year;
        int dobYear = date.Value.Year;

        if (dobYear <= currentYear && dobYear > (currentYear - 120))
        {
            return true;
        }

        return false;
    }
}