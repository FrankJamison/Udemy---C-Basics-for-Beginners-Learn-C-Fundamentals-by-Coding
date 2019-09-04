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

            // Convert to lowercase and slit String
            var words = input.ToLower().Split(' ');

            // Create new variable name
            StringBuilder variableName = new StringBuilder();

            // Capitalize first letter in each element
            for (var ii = 0; ii < words.Length; ii++)
            {
                char[] wordArray = words[ii].ToCharArray();
                wordArray[0] = char.ToUpper(wordArray[0]);
                variableName.Append(new string(wordArray));
            }

            // Display variable name
            Console.WriteLine(variableName);
        }
    }
}
