using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Frontend.Mvc.Models;

namespace Frontend.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var sessions = new Session[]{
            new(){ Title = "Awesome Blazor", Speaker = "John Galloway", Duration = "30 mins" },
            new(){ Title = "C# 10", Speaker = "Mads", Duration = "45 mins" },
            new(){ Title = "Real-world minimal API's", Speaker = "Shawn Wildermuth", Duration = "30 mins" }
        };
        return View(sessions);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
