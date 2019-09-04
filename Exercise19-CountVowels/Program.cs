using System;

namespace Exercise19_CountVowels
{
    /*
     * Write a program and ask the user to enter an English word. 
     * Count the number of vowels (a, e, o, u, i) in the word. 
     * So, if the user enters "inadequate", the program should display 6 on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.WriteLine("Please enter a word: ");
            var input = Console.ReadLine();

            // Check for null or whitespace
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            // Vowel Count
            var vowelCount = 0;

            foreach (var letter in input.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
            }

            // Display vowel count
            Console.WriteLine(vowelCount);
        }
    }
}
