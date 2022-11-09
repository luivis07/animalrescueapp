using AutoMapper;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class ValidationResultMap : Profile
    {
        public ValidationResultMap()
        {
            CreateMap<ValidationResult, ValidationResult>();    
        }
    }
}