using coreMiddlewareApp.Middlewares;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace coreMiddlewareApp.Filters
{
    public class RequestLoggingFilter: ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var request = context.HttpContext.Request;
            var method = request.Method;
            var url = request.Path;


            // Get logger from DI
            var _logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<RequestLoggingFilter>>();

            _logger.LogInformation($" - Incoming Request: {method} | {url}");
            await next();
        }
    }
}
