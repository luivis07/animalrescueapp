using OrchardCore.Users;
using OrchardCore.Users.Events;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;

namespace animalrescue.mainmodule.web.events
{
    public class UserRegistrationEvent : IRegistrationFormEvents
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;

        public UserRegistrationEvent(IAnimalRescueAccountHandler animalRescueAccountHandler)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
        }
        public Task RegisteredAsync(IUser user)
        {
            animalRescueAccountHandler.Create(new AnimalRescueAccountDto
            {
                Username = user.UserName
            });
            return Task.CompletedTask;
        }

        public Task RegistrationValidationAsync(Action<string, string> reportError) => Task.CompletedTask;
    }
}