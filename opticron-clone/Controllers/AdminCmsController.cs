using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AdminCms.Controllers;

public class AdminCmsController : Controller
{
    //
    // GET: /AdminCms
    public IActionResult Index()
    {
        return View();
    }
}

/*
    TODO:: 
        - Create an Update CRUD op on the data through
                    this controller
        - Utilize data.Id as base for updates.
*/