using System;

namespace Exercise7_CalculateFactorial
{
    /*
     * Write a program and ask the user to enter a number. 
     * Compute the factorial of the number and print it on the console. 
     * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Variable to hold factorial
            var factorial = 1;

            // Get number from user
            Console.WriteLine("Please enter a number to find its factorial: ");
            var number = Convert.ToInt32(Console.ReadLine());

            // Calculate factorial
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            // Display factorial
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
