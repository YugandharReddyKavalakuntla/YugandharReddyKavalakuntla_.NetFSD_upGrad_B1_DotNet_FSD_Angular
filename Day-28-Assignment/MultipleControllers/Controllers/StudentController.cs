using Microsoft.AspNetCore.Mvc;

namespace MultipleControllers.Controllers;

public class StudentController : Controller{


    public IActionResult Index(){
        return Content("This is Student Index Page...");
    }


    public IActionResult Profile(){
        return Content("This is Student Profile Page...");
    }



}