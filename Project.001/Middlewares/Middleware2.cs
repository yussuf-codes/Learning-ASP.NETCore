using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace Project._001.Middlewares;

internal class Middleware2
{
    private readonly RequestDelegate _next;

    public Middleware2(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("Entering middleware #2");
        await _next(context);
        Console.WriteLine("Exiting middleware #2");
    }
}
