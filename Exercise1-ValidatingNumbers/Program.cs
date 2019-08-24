using System;

namespace Exercise1_ValidatingNumbers
{
    /* 
    * Write a program and ask the user to enter a number. 
    * The number should be between 1 to 10. 
    * If the user enters a valid number, display "Valid" on the console. 
    * Otherwise, display "Invalid".
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Get number from user
            Console.WriteLine("Please enter a number between 1 and 10.");
            var number = Convert.ToInt32(Console.ReadLine());

            // Display validity of number entered
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
