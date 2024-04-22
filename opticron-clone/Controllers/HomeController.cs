using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using opticron_clone.Models;

namespace opticron_clone.Controllers;

/*
    TODO:: 
        - Create database and context
        - Pass the data for each ViewData to this controller
        - Create models for the data
*/

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
        // View Data, variable assignment for home page
        ViewData["FeatureTitle"] = "Feature Title";
        ViewData["FImageSrc"] = "/images/blueTit.png";
        ViewData["FDescription"] = "Lorem Impsum Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore numquam repudiandae quaerat.";
        ViewData["FBtnText"] = "Button Txt";
        ViewData["OSectionTitle"] = "Special Offers";
        ViewData["OfferTitle"] = "Title Text";
        ViewData["OfferDesc"] = "Strong Desc Text";
        ViewData["OBtnText"] = "View All Offers";
        ViewData["CatagoryTitle"] = "Product Catagories";
        ViewData["CatImage"] = "/images/binocular.png";
        ViewData["CatName"] = "Catagory Name";
        // Return index.cshtml after data has been assigned
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
