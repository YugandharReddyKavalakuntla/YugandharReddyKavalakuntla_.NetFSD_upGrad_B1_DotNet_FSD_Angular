using System;


namespace Assignment2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise1.display();

            //  exercise2
            if(args.Length == 0)
            {
                Console.WriteLine("Please provide your name as a command line argument.");
                return;
            }
            string username = args[0];

            Exercise2 obj2 = new Exercise2();
            obj2.greetUser(username);

            // exercise 3
            if (args.Length < 2)
            {
                Console.WriteLine("Please provide two numbers as command-line arguments.");
                return;
            }

            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);

            Exercise3 obj3 = new Exercise3();
            obj3.PrintNumbersBetween(num1, num2);
                
            // exercise4
            Exercise4 obj4 = new Exercise4();
            obj4.CheckOddOrEven();

            // exercise5
            Exercise5 obj5 = new Exercise5();
            obj5.CountOddEven();

            //exercise6
            Exercise6 obj6 = new Exercise6();
            obj6.FahrenheitTocelsius();


            //exercise7
            Exercise7 obj7 = new Exercise7();
            obj7.CalculateTotalPrice();

            //exercise8
            Exercise8 obj8 = new Exercise8();
            obj8.perfectSquares();

            //exercise9
            Exercise9 obj9 = new Exercise9();
            obj9.FindFactorial();

             //exercise10
            Exercise10 obj10 = new Exercise10();
            obj10.GenerateFibonacci();

            //exercise11
            Exercise11 obj11 = new Exercise11();
            obj11.PrintTable();


            //exercise12
            Exercise12 obj12 = new Exercise12();
            obj12.PrintDivisibleBy7();

            //exercise13
            Exercise13 obj13 = new Exercise13();
            obj13.FindLargest();

            //exercise14
            Exercise14 obj14 = new Exercise14();
            obj14.FindSmallest();

            //exercise15
            Exercise15 obj15 = new Exercise15();
            obj15.ProcessMarks();


            //exercise16
            Exercise16 obj16 = new Exercise16();
            obj16.DisplayWordLength();

            //exercise17
            Exercise17 obj17 = new Exercise17();
            obj17.ReverseWord();

            //exercise18
            Exercise18 obj18 = new Exercise18();
            obj18.CompareWords();


            //exercise18
            Exercise19 obj19 = new Exercise19();
            obj19.CheckPalindrome();

            
        }
    }
    
}