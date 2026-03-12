// Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.


using System;


namespace Assignment2
{

    public class Exercise6
    {
        public void FahrenheitTocelsius(){
            double fahrenheit, celsius;

            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius: " + celsius);
        }


    }

   
    
}