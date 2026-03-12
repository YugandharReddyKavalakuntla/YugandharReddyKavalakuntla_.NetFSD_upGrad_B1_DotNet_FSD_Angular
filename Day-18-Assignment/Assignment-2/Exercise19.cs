// Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.



using System;


namespace Assignment2
{

    public class Exercise19
    {
        public  void CheckPalindrome()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string lowerWord = word.ToLower();

            char[] chars = lowerWord.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            if (lowerWord == reversed)
            {
                Console.WriteLine($"'{word}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{word}' is not a palindrome.");
            }
        }
        
        
    }
}