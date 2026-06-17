using BuberDinner.Application.Authentication.Commands.Register;
using FluentValidation;

namespace BuberDinner.Application.Authentication.Queries.Login;

public class LoginQueryValidator : AbstractValidator<LoginQuery>
{
    public LoginQueryValidator()
    {
        RuleFor(X => X.Email).NotEmpty();
        RuleFor(X => X.Password).NotEmpty();
    }
}
