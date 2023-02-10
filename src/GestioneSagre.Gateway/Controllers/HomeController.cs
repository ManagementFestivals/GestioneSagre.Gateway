using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace GestioneSagre.Gateway.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class HomeController : ControllerBase
{
    public HomeController()
    {
    }

    [HttpGet]
    public IActionResult Welcome()
    {
        var todayDateTime = DateTime.Now;

        return Ok($"Hello World at {todayDateTime.ToString("HH:mm:ss")} hours of day {todayDateTime.ToString("dd/MM/yyyy")} !");
    }
}