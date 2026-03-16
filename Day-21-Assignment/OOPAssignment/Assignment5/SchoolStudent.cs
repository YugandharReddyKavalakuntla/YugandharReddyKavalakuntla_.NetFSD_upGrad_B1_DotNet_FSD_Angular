using System;

namespace StudentAssignment
{
    public class SchoolStudent : Student
    {
        public SchoolStudent(int id, string name, int marks)
            : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            string result = Marks > 40 ? "Pass" : "Fail";

            Console.WriteLine($"School Student: {Name}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Result: {result}");
        }
    }
}