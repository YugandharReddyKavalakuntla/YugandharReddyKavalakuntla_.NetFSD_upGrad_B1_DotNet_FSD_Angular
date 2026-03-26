using Microsoft.AspNetCore.Mvc;


namespace MultipleControllers.Controllers;


public class TeacherController : Controller{

    public IActionResult Index(){
        return Content("This is Teacher Index Page...");
    }


    public IActionResult Details(){
        return Content("This Is Teacher Details Page...");
    }



}