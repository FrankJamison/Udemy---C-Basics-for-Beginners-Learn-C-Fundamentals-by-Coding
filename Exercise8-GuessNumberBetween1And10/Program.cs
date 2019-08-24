using System;

namespace Exercise8_GuessNumberBetween1And10
{
    /*
     * Write a program that picks a random number between 1 and 10. 
     * Give the user 4 chances to guess the number. 
     * If the user guesses the number, display “You won"; otherwise, display “You lost". 
     * (To make sure the program is behaving correctly, you can display the secret number on the console first.)
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Generate target random number
            var random = new Random();
            var targetNumber = random.Next(1, 10);

            // Variables for tries and guesses
            var tries = 0;
            var guess = 0;

            // Prompt the user to guess the number
            Console.WriteLine("Can you guess the random number between 1 and 10?");

            while (guess != targetNumber && tries < 4)
            {
                // Increment tries
                tries += 1;

                // Get guess from user
                Console.WriteLine("Please enter guess {0}: ", tries);
                guess = Convert.ToInt32(Console.ReadLine());
            }

            // Display outcome
            if (guess == targetNumber)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost. The target number was {0}", targetNumber);
            }
        }
    }
}
