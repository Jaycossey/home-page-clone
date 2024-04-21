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
}