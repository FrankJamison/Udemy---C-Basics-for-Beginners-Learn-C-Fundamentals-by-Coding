using System;

namespace Exercise3_FindingImageOrientation
{
    /*
     * Write a program and ask the user to enter the width and height of an image. 
     * Then tell if the image is landscape or portrait.
     */

    class Program
    {
        enum orientation
        {
            landscape = 0,
            portrait = 1
        }

        static void Main(string[] args)
        {
            // Get image height from user
            Console.WriteLine("Please enter the image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            // Get image width from user
            Console.WriteLine("Please enter the image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            // Determine orientation using enum
            var orientation = (height < width) ? 0 : 1;

            // Display image orientation using enum
            Console.WriteLine("Your image orientation is " + (orientation)orientation);
        }
    }
}
