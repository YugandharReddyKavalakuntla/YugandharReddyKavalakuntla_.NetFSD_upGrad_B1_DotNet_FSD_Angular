// Assignment 5: Multiple Parameters
// Scenario: Calculator
// Tasks:
// 1. Create MathController
// 2. Add actions:
// o Add(int a, int b)
// o Multiply(int a, int b)
// 3. Return result


using Microsoft.AspNetCore.Mvc;

namespace PassingSimpleParameters;

public class MathController : Controller{

    public IActionResult Add(int a, int b){
        string result = ($"Addition of {a} and {b} = {a + b}");
        return Content(result);
    }




}