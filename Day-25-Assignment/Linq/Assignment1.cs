using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Linq
{
    internal class Assignment1
    {
        public class Student
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public int Age { get; set; }
            public int Marks { get; set; }

        }
        public static void Main(String[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "gayi", Age = 20, Marks = 85 },
                new Student { Id = 2, Name = "yogi", Age = 22, Marks = 65 },
                new Student { Id = 3, Name = "anju", Age = 18, Marks = 90 },
                new Student { Id = 4, Name = "harsh", Age = 26, Marks = 70 },
                new Student { Id = 5, Name = "chotu", Age = 24, Marks = 95 }

            };
            //Get all students with marks > 75
            var result = students.Where(s =>s.Marks > 75);
            foreach(var student in result)
            {
                Console.WriteLine("Id: " + student.Id + "Name: " + student.Name);
            }

            //Get students whose age is between 18 and 25
            var studentAge = students.Where(s => s.Age >= 18 && s.Age <= 25);
            foreach (var student in studentAge)
            {
                Console.WriteLine("Student age between 18 and 25 are : " + student.Name);
            }

            // Sort students by Marks (descending)
            var Grade = students.OrderByDescending(s => s.Marks);
            Console.WriteLine("students sorted by marks in descending: ");
            foreach (var student in Grade)
                Console.WriteLine("Name: " + student.Name + "Marks: " + student.Marks);

            var details = students.Select(s => new { s.Name, s.Marks });

            foreach(var student in details)
            {
                Console.WriteLine(student.Name + student.Marks);
            }
        }
    }
}
