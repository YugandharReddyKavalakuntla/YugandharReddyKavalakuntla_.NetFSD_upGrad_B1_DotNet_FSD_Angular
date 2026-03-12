
// Write a program in C# to generate a Fibonacci series till 40.


using System;


namespace Assignment2
{

    public class Exercise10
    {
        public  void GenerateFibonacci()
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            while (true)
            {
                c = a + b;

                if (c > 40)
                    break;

                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
        
    }
}