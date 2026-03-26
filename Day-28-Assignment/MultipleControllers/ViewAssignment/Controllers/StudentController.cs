// Assignment 7: Passing Data to View
// Scenario: Student page
// Tasks:
// 1. Create StudentController
// 2. Action:
// 3. public IActionResult Details()
// 4. Pass:
// o Name
// o Age
// 5. Display in view


using Microsoft.AspNetCore.Mvc;
namespace ViewAssignment;

public class StudentController : Controller{

    public IActionResult Details(string name, int age){
        ViewBag.Name = name;
        ViewBag.Age = age;
        return View();

        

    }
}