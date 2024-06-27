using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Project001.MiddlewarePipeline.Middlewares;

namespace Project001.MiddlewarePipeline;

internal class Program
{
    private static void Main()
    {
        // Dependency injection inversion of control container
        WebApplicationBuilder builder = WebApplication.CreateBuilder();
        {
            // Scans the assembly for controller implementations with [ApiController] attribute
            builder.Services.AddControllers();
        }

        // Middleware Pipeline
        WebApplication app = builder.Build();
        {
            app.UseMiddleware<Middleware1>();
            app.UseMiddleware<Middleware2>();
            app.UseMiddleware<Middleware3>();
        }

        // Routing to controller actions & Model binding
        app.MapControllers();

        app.Run();
    }
}
