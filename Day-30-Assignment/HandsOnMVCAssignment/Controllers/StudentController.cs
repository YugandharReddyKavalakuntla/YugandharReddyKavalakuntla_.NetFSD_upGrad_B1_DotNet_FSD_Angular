using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCAssignment.Controllers{


    public class StudentController : Controller{

        public IActionResult Index(){
            var student = new HandsOnMVCAssignment.Models.Student{
                ID = 101,
                Name = "Santhoshni Reddy",
                Age = 23,
                Email ="bagapaliSanthu@gitam.in"
            };
            return View(student);
        }
        public IActionResult Details(){
            ViewData["Name"] = "Yugandhar";
            ViewBag.Education = "B.tech";
            return View();
        }

        public IActionResult GetStudent(int id){

           
            
            return Content("Student Id is" + id);
        }








    }







}