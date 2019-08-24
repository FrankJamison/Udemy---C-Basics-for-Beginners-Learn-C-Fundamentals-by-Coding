using System;

namespace Exercise6_CalculateSumOfNumbers
{
    /*
     * Write a program and continuously ask the user to enter a number or "ok" to exit. 
     * Calculate the sum of all the previously entered numbers and display it on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var input = "";

            while (true)
            {
                // Get user input
                Console.WriteLine("Please enter a number or enter 'OK' to exit: ");
                input = Console.ReadLine();

                // Break out of loop if input is "OK"
                if (input == "OK")
                {
                    break;
                }

                // Add input number to sum
                sum += Convert.ToInt32(input);
            }

            // Display sum of numbers
            Console.WriteLine("The sum of the numbers entered is " + sum);
        }
    }
}
