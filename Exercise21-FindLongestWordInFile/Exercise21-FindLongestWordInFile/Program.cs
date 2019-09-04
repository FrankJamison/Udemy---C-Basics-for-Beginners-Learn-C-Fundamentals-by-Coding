using System;
using System.IO;

namespace Exercise21_FindLongestWordInFile
{
    /*
     * Write a program that reads a text file and displays the longest word in the file.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Relative File Path
            var file = @"../../../text.txt";

            // Get longest word from file
            Console.WriteLine(getLongestWord(file));
        }

        public static string getLongestWord(string file)
        {
            // variables
            var longestWord = "";
            var highestLetterCount = 0;

            //  Get text from file
            var text = File.ReadAllText(file);

            // Split text string into words
            var words = text.Split(' ');

            // Find longest word
            foreach (var word in words)
            {
                if (word.Length > highestLetterCount)
                {
                    highestLetterCount = word.Length;
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
