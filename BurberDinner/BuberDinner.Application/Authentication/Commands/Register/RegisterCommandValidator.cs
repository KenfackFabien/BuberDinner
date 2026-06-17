using FluentValidation;

namespace BuberDinner.Application.Authentication.Commands.Register;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(X => X.FirstName).NotEmpty();
        RuleFor(X => X.LastName).NotEmpty();
        RuleFor(X => X.Email).NotEmpty();
        RuleFor(X => X.Password).NotEmpty();
    }
}
