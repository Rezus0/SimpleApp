using Microsoft.AspNetCore.Mvc;
using SimpleApp.models;

namespace SimpleApp.controllers;

[ApiController]
[Route("api/[controller]")]
public class MovieController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMovie()
    {
        return Ok(new Movie { Id = 6, Title = "Inception", Director = "Christopher Nolan" });
    }
}