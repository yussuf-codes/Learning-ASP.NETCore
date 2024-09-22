using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Project003.ActionFilters.Filters;

public class AttributeFilter : ActionFilterAttribute
{
    private readonly ILogger<AttributeFilter> _logger;

    public AttributeFilter(ILogger<AttributeFilter> logger)
    {
        _logger = logger;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        _logger.LogInformation("Executing, Action Filter Attribute");
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        _logger.LogInformation("Executed, Action Filter Attribute");
    }
}
