using System;

namespace StudentAssignment
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, int marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;
        }

        public virtual void CalculateGrade()
        {
            string result = Marks > 50 ? "Pass" : "Fail";

            Console.WriteLine($"Student: {Name}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Result: {result}");
        }
    }
}