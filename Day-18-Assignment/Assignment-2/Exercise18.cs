// Write a program in C# to accept two words from user and find out if they are same.




using System;


namespace Assignment2
{

    public class Exercise18
    {
        public  void CompareWords()
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (word1 == word2)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
        }
        
        
    }
}