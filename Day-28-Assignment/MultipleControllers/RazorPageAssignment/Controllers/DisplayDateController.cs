// Assignment 11: Razor Syntax Basics
// Scenario: Display current date
// Tasks:
// 1. In View:
// 2. <p>Today: @DateTime.Now</p>


using Microsoft.AspNetCore.Mvc;
namespace RazorPageAssignment;

public class DisplayDateController : Controller{

    public IActionResult Today(){
        return View();
    }







}