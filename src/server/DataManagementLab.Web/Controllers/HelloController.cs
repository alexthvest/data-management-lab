using System;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult GetResponse()
    {
        return Ok("Hello, World");
    }
}
