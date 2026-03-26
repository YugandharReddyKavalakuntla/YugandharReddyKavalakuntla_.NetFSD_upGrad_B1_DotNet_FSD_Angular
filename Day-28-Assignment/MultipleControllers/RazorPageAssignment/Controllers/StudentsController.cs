// Assignment 13: Loop in Razor
// Scenario: Display list of students
// Tasks:
// 1. Pass list from controller
// 2. Use:
// 3. @foreach(var student in students)
// 4. {
// 5. <p>@student</p>
// 6. }

using Microsoft.AspNetCore.Mvc;
namespace RazorPageAssignment;

public class StudentsController : Controller{

    public IActionResult Display(){

        List<string> students = new List<string>(){
            "Yugandhar",
            "Santhoshni",
            "Jahanavi",
            "Keerthana",
            "Sreeja",
            "Mooksha",
            "Deeksha",
            "Karthik"
        };

        ViewBag.std = students;
        return View();


    }




}