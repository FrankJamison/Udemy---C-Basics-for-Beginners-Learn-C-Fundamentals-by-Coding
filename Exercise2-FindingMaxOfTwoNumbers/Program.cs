using System;

namespace Exercise2_FindingMaxOfTwoNumbers
{
    /*
     * Write a program which takes two numbers from the console and displays the maximum of the two.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get first number from user
            Console.WriteLine("Please enter the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            // Get second number from user
            Console.WriteLine("Please enter the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            // Determine max number
            var maxNumber = (number1 >= number2) ? number1 : number2;

            // Display max number
            Console.WriteLine("The highest number is " + maxNumber);
        }
    }
}
