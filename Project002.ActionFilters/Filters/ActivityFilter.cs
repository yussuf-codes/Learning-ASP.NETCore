using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Project003.ActionFilters.Filters;

public class ActivityFilter : IActionFilter
{
    private readonly ILogger<ActivityFilter> _logger;

    public ActivityFilter(ILogger<ActivityFilter> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogInformation($"Executing, Name: {context.ActionDescriptor.DisplayName}, Controller: {context.Controller}");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        _logger.LogInformation($"Executed, Name: {context.ActionDescriptor.DisplayName}, Controller: {context.Controller}");
    }
}
