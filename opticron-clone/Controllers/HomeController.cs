using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using opticron_clone.Models;

namespace opticron_clone.Controllers;
// Home Controller handles the navigation and rendering of views through the home directory
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // 
    // Endpoint for Home Page (Index view)
    // GET: /Home
    public IActionResult Index()
    {
        return View();
    }
    // 
    // Retrieve Privacy page view
    // GET: /Home/Privacy
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
