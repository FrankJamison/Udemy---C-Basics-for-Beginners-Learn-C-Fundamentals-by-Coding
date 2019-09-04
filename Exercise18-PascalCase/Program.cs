using System;
using System.Text;

namespace Exercise18_PascalCase
{
    /*
     * Write a program and ask the user to enter a few words separated by a space. 
     * Use the words to create a variable name with PascalCase. 
     * For example, if the user types: "number of students", display "NumberOfStudents". 
     * Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.WriteLine("Please enter a series of words separated by spaces: ");
            var input = Console.ReadLine();

            // Display error if no input
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            // Create PascalCase variable name
            var variableName = "";

            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            // Display variable name
            Console.WriteLine(variableName);
        }
    }
}
