using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace Project._001.Middlewares;

internal class Middleware1
{
    private readonly RequestDelegate _next;

    public Middleware1(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.Write(Environment.NewLine);
        Console.WriteLine("Entering middleware #1");
        await _next(context);
        Console.WriteLine("Exiting middleware #1");
        Console.Write(Environment.NewLine);
    }
}
