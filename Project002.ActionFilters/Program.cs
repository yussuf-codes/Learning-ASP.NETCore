using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Project003.ActionFilters.Filters;

namespace Project003.ActionFilters;

public class Program
{
    public static void Main()
    {
        // Dependency injection inversion of control container
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        // Scans the assembly for controller implementations with [ApiController] attribute
        builder.Services.AddControllers(options =>
        {
            options.Filters.Add<ActivityFilter>();
        });

        // Middleware Pipeline
        builder.Services.AddScoped<AttributeFilter>();

        WebApplication app = builder.Build();

        // Routing to controller actions & Model binding
        app.MapControllers();

        app.Run();
    }
}
