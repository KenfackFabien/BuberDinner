using BuberDinner.Application.Common.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

public class ErrorsConroller : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        
        var (statusCode, message) = exception switch
        {
            IServiceEception serviceEception => ((int)serviceEception.StatusCode, serviceEception.ErrorMessage),
            _ => (StatusCodes.Status500InternalServerError, "An unexcepted error occured."),
        };

        return Problem(statusCode: statusCode, title: message);
    }
} 