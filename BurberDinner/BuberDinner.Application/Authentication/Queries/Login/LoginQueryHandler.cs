using BuberDinner.Application.Authentication.Commands.Common;
using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Common.Interfaces.Authentication;
using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.Common.Errors;
using BuberDinner.Domain.Entities;
using ErrorOr;
using MediatR;


namespace BuberDinner.Application.Authentication.Queries.Login;

public class LoginCommandHandler :
    IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public LoginCommandHandler(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(
        LoginQuery query, CancellationToken cancellationToken)
    {
           // 1. Validte the user exists
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // 2. VAlidate the password is correct
        if (user.Password != query.Password)
        {
            return new [] {Errors.Authentication.InvalidCredentials};
        }

        // 3. Create JWT token
        var token = _jwtTokenGenerator.GeneratorToken(user);
        
        return new AuthenticationResult(
            user,
            token
        );
    }
   
}