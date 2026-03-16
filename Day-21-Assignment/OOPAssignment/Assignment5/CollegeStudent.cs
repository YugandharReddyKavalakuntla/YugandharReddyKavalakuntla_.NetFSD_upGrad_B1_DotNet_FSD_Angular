using System;

namespace StudentAssignment
{
    public class CollegeStudent : Student
    {
        public CollegeStudent(int id, string name, int marks)
            : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            string result = Marks > 50 ? "Pass" : "Fail";

            Console.WriteLine($"College Student: {Name}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Result: {result}");
        }
    }
}