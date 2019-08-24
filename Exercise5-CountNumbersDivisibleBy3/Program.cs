using System;

namespace Exercise5_CountNumbersDivisibleBy3
{
    /*
     * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
     * Display the count on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create variable to hold count of numbers divisible by 3
            var count = 0;

            // Loop through numbers between 0 and 100
            for (int i = 1; i <= 100; i++)
            {
                // Increment counter for each number divisible by 3
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            // DIsplay count of numbers between 1 and 100 that are divisible by 3
            Console.WriteLine("There are " + count + " numbers divisible by 3 between 1 and 100");
        }
    }
}
