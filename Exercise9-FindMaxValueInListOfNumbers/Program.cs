using System;

namespace Exercise9_FindMaxValueInListOfNumbers
{
    /*
     * Write a program and ask the user to enter a series of numbers separated by comma. 
     * Find the maximum of the numbers and display it on the console. 
     * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get input from user
            Console.WriteLine("Please enter a list of comma separated numbers: ");
            var input = Console.ReadLine();

            // Separate numbers into list
            var numbers = input.Split(',');

            // Max Value
            var maxValue = Convert.ToInt32(numbers[0]);

            // Loop through numbers to determine max value
            foreach (var value in numbers)
            {
                // Convert value to integer
                var thisNumber = Convert.ToInt32(value);

                // Determine max value
                if (thisNumber > maxValue)
                {
                    maxValue = thisNumber;
                }
            }

            // Display max value
            Console.WriteLine("The highest number is {0}", maxValue);
        }
    }
}
