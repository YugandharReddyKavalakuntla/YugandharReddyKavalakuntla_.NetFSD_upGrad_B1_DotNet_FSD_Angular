using Microsoft.AspNetCore.Mvc;

namespace PassingSimpleParameters;

public class UserController : Controller{

    public IActionResult Details(string name, int age){
        string result = $"Name : {name}, Age : {age}";
        return Content(result);
    }


}