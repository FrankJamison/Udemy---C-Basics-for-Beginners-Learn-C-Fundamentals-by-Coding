using System;
using System.Collections.Generic;

namespace Exercise10_FacebookLikes
{
    /*
     * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
     * If no one likes your post, it doesn't display anything.
     * If only one person likes your post, it displays: [Friend's Name] likes your post.
     * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
     * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
     * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // list for friends
            var friends = new List<string>();

            // user input
            var input = "";

            // Add friends to list until enter is pressed without a name
            while (true)
            {
                // Get name from of person who likes your post from user
                Console.WriteLine("Please enter a name or press enter to exit: ");
                input = Console.ReadLine();

                // If a name is entered, add it to the friends list
                if (input.Length > 0)
                {
                    friends.Add(input);
                }
                // Else exit the loop
                else
                {
                    break;
                }
            }

            // If only one person likes your post, display: [Friend's Name] likes your post.
            if (friends.Count == 1)
            {
                Console.WriteLine(friends[0] + " likes your post.");
            }
            
            // Else if two people like your post, display: [Friend 1] and [Friend 2] like your post.
            else if (friends.Count == 2)
            {
                Console.WriteLine(friends[0] + " and " + friends[1] + " like your post.");
            }

            // Else if more than two people like your post, display: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            else if (friends.Count > 2)
            {
                Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (friends.Count - 2) + " others like your post.");
            }
        }
    }
}
