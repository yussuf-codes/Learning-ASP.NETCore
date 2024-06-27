using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace Project001.MiddlewarePipeline.Middlewares;

internal class Middleware3
{
    private readonly RequestDelegate _next;

    public Middleware3(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("Entering middleware #3");
        await _next(context);
        Console.WriteLine("Exiting middleware #3");
    }
}
