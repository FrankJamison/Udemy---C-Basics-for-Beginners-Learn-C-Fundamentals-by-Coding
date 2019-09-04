using System;

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

            // Split input at dashes
            var numbers = input.Split("-");

            // Determine if numbers are consecutive
            if (NumberMethods.consecutiveNumbers(numbers, "increasing") || NumberMethods.consecutiveNumbers(numbers, "decreasing")) {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
