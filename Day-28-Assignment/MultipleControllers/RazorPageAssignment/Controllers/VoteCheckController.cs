// Assignment 12: Conditional Rendering
// Scenario: Check age eligibility
// Tasks:
// 1. Pass age from controller
// 2. In view:
// 3. @if(age >= 18)
// 4. {
// 5. <p>Eligible to vote</p>
// 6. }
// 7. else
// 8. {
// 9. <p>Not eligible</p>
// 10. }


using Microsoft.AspNetCore.Mvc;
namespace RazorPageAssignment;

public class VoteCheckController : Controller{

    public IActionResult Vote(){
        ViewData["Age"] = 38;
        return View();
    }

}