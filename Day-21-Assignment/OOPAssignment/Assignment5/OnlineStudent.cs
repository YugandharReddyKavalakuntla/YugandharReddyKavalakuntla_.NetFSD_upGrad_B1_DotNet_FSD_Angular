using System;

namespace StudentAssignment
{
    public class OnlineStudent : Student
    {
        public OnlineStudent(int id, string name, int marks)
            : base(id, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            string result = Marks > 60 ? "Pass" : "Fail";

            Console.WriteLine($"Online Student: {Name}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Result: {result}");
        }
    }
}