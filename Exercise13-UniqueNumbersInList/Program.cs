using System;
using System.Collections.Generic;

namespace Exercise13_UniqueNumbersInList
{
    /*
     * Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
     * The list of numbers may include duplicates. 
     * Display the unique numbers that the user has entered.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create list for numbers
            var numbers = new List<int>();

            // Create input variable
            var input = "";

            // collect data while input is not "Quit"
            while (true)
            {
                // Get a input from the user
                Console.WriteLine("Please enter a number: ");
                input = Console.ReadLine();

                // if input = quit, break out of loop
                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Convert input to number and add to numbers list
                numbers.Add(Convert.ToInt32(input));
            }

            // Sort numbers list
            numbers.Sort();

            // Create list for distinct items
            var uniqueNumbers = new List<int>();

            // Add distinct items to unique numbers list and display unique numbers
            Console.WriteLine();

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                    Console.WriteLine(number);
                }
            }
        }
    }
}
