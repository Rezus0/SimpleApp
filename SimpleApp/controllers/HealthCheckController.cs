using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok("Healthy");
    }
}