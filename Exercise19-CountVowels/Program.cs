using System;
using System.Collections.Generic;

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
            var input = Console.ReadLine().ToLower();

            // Check for null or whitespace
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            // Create a list from a char array with vowels
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });

            // Vowel Count
            var vowelCount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelCount++;
            }
            
            // Display vowel count
            Console.WriteLine(vowelCount);
        }
    }
}
