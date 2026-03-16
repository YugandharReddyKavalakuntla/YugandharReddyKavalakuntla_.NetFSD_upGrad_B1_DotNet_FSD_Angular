using System;

namespace StudentAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new SchoolStudent(1, "Rukaya", 45),
                new CollegeStudent(2, "Santhoshni", 55),
                new OnlineStudent(3, "Nikitha", 58)
            };

            foreach (Student student in students)
            {
                student.CalculateGrade();
                Console.WriteLine();
            }
        }
    }
}