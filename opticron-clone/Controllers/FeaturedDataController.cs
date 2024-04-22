using Microsoft.AspNetCore.Mvc;

namespace FeaturedData.Controllers;

public class FeaturedDataController : Controller
{

    // 
    // GET: /FeaturedData/
    public IActionResult Index()
    {
        ViewData["ItemTitle"] = "Item Title";
        ViewData["ImageSrc"] = "/images/blueTit.png";
        ViewData["Description"] = "Lorem Impsum Lorem ipsum dolor sit amet consectetur adipisicing elit. Labore numquam repudiandae quaerat.";
        ViewData["BtnText"] = "ButtonTxt";
        return View();
    }

}
