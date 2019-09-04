using System;
using System.IO;

namespace Exercise20_CountWordsInFile
{
    /*
     * Write a program that reads a text file and displays the number of words.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Relative File Path
            var file = @"../../../text.txt";
            
            // Display the number of words in a text file
            Console.WriteLine(getNumberOfWords(file));
        }

        public static int getNumberOfWords(string file)
        {
            // Get text from file
            var text = File.ReadAllText(file);

            // Split text into words
            var words = text.Split(' ');

            // Return number of words
            return words.Length;
        }
    }
}
