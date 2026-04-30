using System.Collections.Generic;
namespace HandsOnMVCAssignment.Models{

    public class Student{

        public int ID{get; set;}
        public string? Name{get; set;}

        public int Age{get; set;}

        public string? Email{get; set;}

        public List<Course> Course {get; set;}




    }




}