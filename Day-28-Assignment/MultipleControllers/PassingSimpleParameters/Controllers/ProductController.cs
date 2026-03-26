// Assignment 4
// Scenario: Product details page
// Tasks:
// 1. Create ProductController
// 2. Add action:
// 3. public IActionResult GetProduct(int id)
// 4. Return:
// o "Product Id is: {id}"
//  Try:
// /Product/GetProduct/101


using Microsoft.AspNetCore.Mvc;
namespace PassingSimpleParameters;

public class ProductController : Controller{
    public IActionResult GetProduct(int id){
        return Content ($"Product Id is : {id}");
    }

}