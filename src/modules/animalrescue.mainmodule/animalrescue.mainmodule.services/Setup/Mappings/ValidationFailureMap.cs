using AutoMapper;
using FluentValidation.Results;

namespace animalrescue.mainmodule.services.setup.mappings
{
    public class ValidationFailureMap : Profile
    {
        public ValidationFailureMap()
        {
            CreateMap<ValidationFailure, ValidationFailure>();    
        }
    }
}