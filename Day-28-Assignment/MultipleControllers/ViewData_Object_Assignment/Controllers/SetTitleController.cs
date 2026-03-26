// Assignment 9: Dynamic Page Title
// Scenario: Dynamic titles
// Tasks:
// 1. Set:
// 2. ViewData["Title"] = "Home Page";
// 3. Display in layout or view:
// 4. <title>@ViewData["Title"]</title>



using Microsoft.AspNetCore.Mvc;
namespace ViewData_Object_Assignment;

public class SetTitleController : Controller{

    public IActionResult Title(){
        ViewData["Title"] = "Home Page";
        return View();
    }

}