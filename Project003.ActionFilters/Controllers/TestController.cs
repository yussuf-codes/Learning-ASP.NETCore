using System;
using Microsoft.AspNetCore.Mvc;

using Project003.ActionFilters.Filters;

namespace Project003.ActionFilters.Controllers;

[ApiController]
[Route("api/[controller]")]
// The controller MUST be public
public class TestController : ControllerBase
{
    [HttpGet]
    [ServiceFilter(typeof(AttributeFilter))]
    public void Get()
    {
        Console.WriteLine("\nInside the controller\n");
    }
}
