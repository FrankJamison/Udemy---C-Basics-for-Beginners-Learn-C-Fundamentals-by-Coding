using System;
using System.Collections.Generic;

namespace Exercise12_UniqueNumbers
{
    /*
     * Write a program and ask the user to enter 5 numbers. 
     * If a number has been previously entered, display an error message and ask the user to re-try. 
     * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold the numbers
            var numbers = new List<int>();

            // Get 5 unique numbers from the user
            while (numbers.Count < 5)
            {
                // Get a number from the user
                Console.WriteLine("Plaese enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                // If the entered number is not unique, display error and prompt for new number.
                if (numbers.Contains(number))
                {
                    Console.WriteLine(number + " has already been entered.");
                    continue;
                }

                // Add number to list of numbers
                numbers.Add(number);
            }

            // Sort the list of numbers
            numbers.Sort();

            // Display the sorted list
            Console.WriteLine();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
