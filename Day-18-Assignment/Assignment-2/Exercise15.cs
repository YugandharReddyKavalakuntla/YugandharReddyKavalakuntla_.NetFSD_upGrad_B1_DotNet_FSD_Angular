// Write a program in C# to accept ten marks and display the following
// a. Total
// b. Average
// c. Minimum marks
// d. Maximum marks
// e. Display marks in ascending order
// f. Display marks in descending order


using System;

namespace Assignment2
{
    public class Exercise15
    {

        public  void ProcessMarks()
        {
            int[] marks = new int[10];
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
            }

            double average = total / 10.0;

            // Find minimum and maximum
            int min = marks[0];
            int max = marks[0];
            for (int i = 1; i < 10; i++)
            {
                if (marks[i] < min) min = marks[i];
                if (marks[i] > max) max = marks[i];
            }

            // Sort ascending
            Array.Sort(marks);
            int[] ascending = (int[])marks.Clone();

            // Sort descending
            Array.Reverse(marks);
            int[] descending = (int[])marks.Clone();

            // Display results
            Console.WriteLine($"\nTotal: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Minimum marks: {min}");
            Console.WriteLine($"Maximum marks: {max}");
            Console.WriteLine("Marks in ascending order: " + string.Join(", ", ascending));
            Console.WriteLine("Marks in descending order: " + string.Join(", ", descending));
        }
    }
}