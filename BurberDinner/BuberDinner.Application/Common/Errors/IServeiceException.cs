using System.Net;

namespace BuberDinner.Application.Common.Errors;

public interface IServiceEception
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get; }
}
