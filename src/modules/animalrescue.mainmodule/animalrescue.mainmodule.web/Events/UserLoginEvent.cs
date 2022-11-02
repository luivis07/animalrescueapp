using OrchardCore.Users;
using OrchardCore.Users.Events;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;

namespace animalrescue.mainmodule.web.events
{
    public class UserLoginEvent : ILoginFormEvent
    {
        private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;

        public UserLoginEvent(IAnimalRescueAccountHandler animalRescueAccountHandler)
        {
            this.animalRescueAccountHandler = animalRescueAccountHandler;
        }

        public Task IsLockedOutAsync(IUser user) => Task.CompletedTask;

        public Task LoggedInAsync(IUser user)
        {
            animalRescueAccountHandler.Create(new AnimalRescueAccountDto
            {
                Username = user.UserName
            });
            return Task.CompletedTask;
        }

        public Task LoggingInAsync(string userName, Action<string, string> reportError) => Task.CompletedTask;

        public Task LoggingInFailedAsync(string userName) => Task.CompletedTask;

        public Task LoggingInFailedAsync(IUser user) => Task.CompletedTask;
    }
}