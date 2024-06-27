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
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddSingleton<IGenericRepository<ToDo>, InMemoryToDosRepository>();

        WebApplication app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
