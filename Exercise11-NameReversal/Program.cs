using System;

namespace Exercise11_NameReversal
{
    /*
     * Write a program and ask the user to enter their name. 
     * Use an array to reverse the name and then store the result in a new string. 
     * Display the reversed name on the console.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get a name from the user
            Console.WriteLine("Please enter a name: ");
            var name = Console.ReadLine();

            // Create an array for the name
            var nameArray = new char[name.Length];

            // Populate name array with reversed string characters
            for (int i = name.Length; i > 0; i--)
            {
                nameArray[name.Length - i] = name[i - 1];
            }

            // Convert Array to String
            var nameReversed = string.Join("", nameArray);

            // Display the reversed name
            Console.WriteLine("The name reversed is " + nameReversed);
        }
    }
}
