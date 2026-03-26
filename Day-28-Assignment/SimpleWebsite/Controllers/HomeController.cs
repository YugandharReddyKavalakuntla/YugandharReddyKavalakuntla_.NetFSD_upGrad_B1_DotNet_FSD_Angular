using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleWebsite.Models;

namespace SimpleWebsite.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }


    public IActionResult Index(){
        return Content( "Welcome to ASP.NET Core MVC");

    }

    public IActionResult About(){
        return Content("This is About Page");
    }

    public IActionResult Contact(){
        return Content("Contact us at support@test.com");
    }




}
