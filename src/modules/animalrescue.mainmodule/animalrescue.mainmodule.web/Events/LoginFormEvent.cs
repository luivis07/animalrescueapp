using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using OrchardCore.Users;
using OrchardCore.Users.Events;

namespace animalrescue.mainmodule.web.events;

public class LoginFormEvent : ILoginFormEvent
{
    private readonly IAnimalRescueAccountHandler animalRescueAccountHandler;

    public LoginFormEvent(IAnimalRescueAccountHandler animalRescueAccountHandler)
    {
        this.animalRescueAccountHandler = animalRescueAccountHandler;
    }
    public Task IsLockedOutAsync(IUser user)
    {
        return Task.CompletedTask;
    }

    public Task LoggedInAsync(IUser user)
    {
        var exists = animalRescueAccountHandler.GetByUsername(user.UserName);
        if(exists == null)
        {
            animalRescueAccountHandler.Create(new AnimalRescueAccountDto
            {
                Username = user.UserName
            });
        }
        return Task.CompletedTask;
    }

    public Task LoggingInAsync(string userName, Action<string, string> reportError)
    {
        return Task.CompletedTask;
    }

    public Task LoggingInFailedAsync(string userName)
    {
        return Task.CompletedTask;
    }

    public Task LoggingInFailedAsync(IUser user)
    {
        return Task.CompletedTask;
    }
}