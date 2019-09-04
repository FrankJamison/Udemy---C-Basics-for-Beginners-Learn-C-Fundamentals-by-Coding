using System;
using System.Collections.Generic;

namespace Exercise15_DuplicateNumbersTest
{
    /* 
     * Write a program and ask the user to enter a few numbers separated by a hyphen. 
     * If the user simply presses Enter, without supplying an input, exit immediately; 
     * otherwise, check to see if there are duplicates. 
     * If so, display "Duplicate" on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.WriteLine("Please enter a series of numbers separated by hyphens (-): ");
            var input = Console.ReadLine();

            // Check for null or empty
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

            if (HasDuplicateNumbers(input))
            {
                Console.WriteLine("Duplicates");
            }
        }

        public static bool HasDuplicateNumbers(string input)
        {
            // Create a list for the numbers
            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            // Sort the numbers
            numbers.Sort();

            // Check for duplicates
            for (var ii = 1; ii < numbers.Count; ii++)
            {
                if (numbers[ii] == numbers[ii - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
