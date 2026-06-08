using System.Threading.Tasks;
using BuberDinner.Application.Authentication.Commands.Common;
using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Contracts.Authentication;
using BuberDinner.Domain.Common.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;

    public AuthenticationController(ISender sender)
    {
        _mediator = sender;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        ErrorOr<AuthenticationResult> registerResult = await _mediator.Send(command);

        return registerResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors));
        
    }

    private static AuthenticationResponse MapAuthResult(AuthenticationResult authResult)
    {
        return new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(request.Email, request.Password);

        var authResult = await _mediator.Send(query);

        if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
        {
            return Problem(
                statusCode: StatusCodes.Status401Unauthorized,
                title: authResult.FirstError.Description);
        }
        
        return authResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors)
        );
    }
}