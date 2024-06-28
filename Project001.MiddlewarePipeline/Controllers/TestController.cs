using System;
using Microsoft.AspNetCore.Mvc;

namespace Project001.MiddlewarePipeline.Controllers;

[ApiController]
[Route("api/[controller]")]
// The controller MUST be public
public class TestController : ControllerBase
{
    [HttpGet]
    public void Get()
    {
        Console.WriteLine("\nInside the controller\n");
    }
}
