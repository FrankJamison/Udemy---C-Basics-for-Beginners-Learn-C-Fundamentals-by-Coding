using System;
using System.Collections.Generic;

namespace Exercise14_SmallestThreeNumbers
{
    /*
     * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
     * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
     * otherwise, display the 3 smallest numbers in the list.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // String to hold numbers
            String[] elements;

            // Collect input and validate number of elements
            while (true)
            {
                // Get input string from user
                Console.WriteLine("Please enter a list of comma separated numbers: ");
                var input = Console.ReadLine();

                // If the input string is not empty...
                if (!String.IsNullOrWhiteSpace(input))
                {
                    // Split the input into indidudual strings in the numbers array
                    elements = input.Split(',');

                    // If there are 5 or more strings, break out of loop
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }

                // Display invalid list error
                Console.WriteLine("Invalid List");
            }

            // Create list to hold numbers
            var numbers = new List<int>();

            // Convert elements to numbers and add to list
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            // Sort list
            numbers.Sort();

            // Display the 3 smallest numbers in the list
            Console.WriteLine("The three smallest numbers in the list are {0}, {1}, and {2}.", numbers[0], numbers[1], numbers[2]);
        }
    }
}
