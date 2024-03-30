using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Project._002.Models;
using Project._002.Repositories;
using Project._002.Repositories.IRepositories;

namespace Project._002;

public class Program
{
    public static void Main()
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddSingleton<IGenericRepository<ToDo>, InMemoryToDosRepository>();

        WebApplication app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
