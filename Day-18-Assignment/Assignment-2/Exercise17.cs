
// Write a program in C# to accept a word from the user and display the reverse of it.


using System;


namespace Assignment2
{

    public class Exercise17
    {
        public  void ReverseWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            string reversed = new string(chars);

            Console.WriteLine($"The reverse of '{word}' is: {reversed}");
        }
        
    }
}