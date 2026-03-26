// Assignment 10: Passing Multiple Values
// Scenario: Employee details
// Tasks:
// 1. Pass:
// o Name
// o Salary
// o Department
// 2. Display all using ViewData

using Microsoft.AspNetCore.Mvc;
namespace ViewData_Object_Assignment;

public class EmployeDetailsController : Controller{

    public IActionResult EDetails(){
        ViewData["Name"] = "Yugandhar Reddy Kavalakuntla";
        ViewData["Salary"] = 180000;
        ViewData["Department"] = "AI Engineer";
        return View();
    }

}