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

    public async Task<IActionResult> Index()
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://cont-sessions-service.niceglacier-0de66fcf.northeurope.azurecontainerapps.io")
        };

        var sessions = await httpClient.GetFromJsonAsync<IEnumerable<Session>>("sessions");

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
