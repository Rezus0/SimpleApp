using Microsoft.AspNetCore.Mvc;
using SimpleApp.models;

namespace SimpleApp.controllers;

[ApiController]
[Route("api/[controller]")]
public class SongController : ControllerBase
{
    [HttpGet]
    public IActionResult GetSong()
    {
        return Ok(new Song { Id = 1, Title = "Pokerface", Author = "Lady Gaga" });
    }
}