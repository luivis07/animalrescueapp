using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace animalrescue.mainmodule.web.controllers
{
    [Route("/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        public void AddToModelState(ValidationResult result)
        {
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
        }
    }
}