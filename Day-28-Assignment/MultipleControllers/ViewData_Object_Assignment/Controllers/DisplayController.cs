// Assignment 8: ViewData Basics
// Scenario: Show user info
// Tasks:
// 1. In controller:
// 2. ViewData["Name"] = "John";
// 3. ViewData["Age"] = 25;
// 4. Display in View using:
// 5. @ViewData["Name"]


using Microsoft.AspNetCore.Mvc;
namespace ViewData_Object_Assignment;

public class DisplayController : Controller{

    public IActionResult Show(){
        ViewData["Name"] = "John";
        ViewData["Age"] = 25;
        return View();
    }


}