using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AdminCms.Controllers;

public class AdminCmsController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 

    public IActionResult Welcome(string name, int ID = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["ID"] = ID;
        return View();
    }
}