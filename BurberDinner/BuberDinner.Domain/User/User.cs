using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.User.ValueObjects;

namespace BuberDinner.Domain.User;

public sealed class User : AggregateRoot<UserId>
{
    public string FirstName;
    public string LastName;
    public string Email;
    public string Password;
    public DateTime CreatedDateTime;
    public DateTime UpdatedDateTime;

    private User(
        UserId UserId,
        string firstName,
        string lastName,
        string email,
        string password,
        DateTime createdDateTime,
        DateTime updatedDateTime
    ) : base(UserId)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public User Create(
        string firstName,
        string lastName,
        string email,
        string password
    )
    {
        return new(
            UserId.CreateUnique(),
            firstName,
            lastName,
            email,
            password,
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}