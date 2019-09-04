using System;
using System.Collections.Generic;

namespace Exercise15_ConsecutiveNumberTest
{
    /*
     * Write a program and ask the user to enter a few numbers separated by a hyphen. 
     * Work out if the numbers are consecutive. 
     * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
     * otherwise, display "Not Consecutive".
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get user input
            Console.WriteLine("Please enter a series of numbers separated by dashes (-): ");
            var input = Console.ReadLine();

            // Create list of numbers from input
            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            // Sort numbers
            numbers.Sort();

            // Consecutive Numbers Flag
            var isConsecutive = true;

            // Check for consecutive numbers
            for (var ii = 1; ii < numbers.Count; ii++)
            {
                if(numbers[ii] != numbers[ii-1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            // Generate Message
            var message = isConsecutive ? "Consecutive" : "Not Consecutive";

            // Display Message
            Console.WriteLine(message);
        }
    }
}
