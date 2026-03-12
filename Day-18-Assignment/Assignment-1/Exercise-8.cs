// Write an algorithm for accepting third character of the given string and then display whether it is
// vowel or constant
using System;

namespace Assignment
{
    public class Excrcise8
    {
        public void CheckThirdCharacter()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input.Length < 3)
            {
                Console.WriteLine("String is too short. Please enter at least 3 characters.");
                return;
            }

            char thirdChar = input[2];
            char lowerChar = char.ToLower(thirdChar);

            if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            {
                Console.WriteLine("Third character '" + thirdChar + "' is a vowel.");
            }
            else
            {
                Console.WriteLine("Third character '" + thirdChar + "' is a consonant.");
            }
        }
    }
}