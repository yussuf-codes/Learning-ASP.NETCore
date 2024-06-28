using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Project002.BasicCRUD.Models;
using Project002.BasicCRUD.Repositories;
using Project002.BasicCRUD.Repositories.IRepositories;

namespace Project002.BasicCRUD;

public class Program
{
    public static void Main()
    {
        // Dependency injection inversion of control container
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        {
            // Scans the assembly for controller implementations with [ApiController] attribute
            builder.Services.AddControllers();

            // Creates a single instance that is used across the application lifetime
            builder.Services.AddSingleton<IGenericRepository<ToDo>, InMemoryToDosRepository>();
        }

        WebApplication app = builder.Build();

        // Routing to controller actions & Model binding
        app.MapControllers();
        app.Run();
    }
}
