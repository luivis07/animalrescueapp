using OrchardCore.Users;
using OrchardCore.Users.Events;

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
            await animalRescueAccountHandler.CreateAsync(new AnimalRescueAccountDto
            {
                Username = user.UserName
            });
            return Task.CompletedTask;
        }

        public Task RegistrationValidationAsync(Action<string, string> reportError) => Task.CompletedTask;
    }
}