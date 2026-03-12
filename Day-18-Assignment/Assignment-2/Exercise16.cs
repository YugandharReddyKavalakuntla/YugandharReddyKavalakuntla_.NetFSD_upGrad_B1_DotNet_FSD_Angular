// Write a program in C# to accept a word from the user and display the length of it.



using System;


namespace Assignment2
{

    public class Exercise16
    {
        public  void DisplayWordLength()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;

            Console.WriteLine($"The length of the word '{word}' is: {length}");
        }
        
    }
}