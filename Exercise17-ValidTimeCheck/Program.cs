using System;

namespace Exercise17_ValidTimeCheck
{
    /*
     * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
     * A valid time should be between 00:00 and 23:59. 
     * If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
     * If the user doesn't provide any values, consider it as invalid time.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get User Input
            Console.WriteLine("Please enter a time in military format (HH:MM): ");
            var input = Console.ReadLine();

            Console.WriteLine(validateTime(input));
        }
        
        public static string validateTime(string input)
        {
            // If null or empty, display invalid time
            if (String.IsNullOrEmpty(input))
            {
                return "Invalid Time";
            }

            // Split time into components
            var timeComponents = input.Split(':');

            // If there are more than 2 components, display invalid time
            if (timeComponents.Length > 2)
            {
                return "Invalid Time";
            }

            try
            {
                // Split time components into hours and minutes
                var hours = Convert.ToInt32(timeComponents[0]);
                var minutes = Convert.ToInt32(timeComponents[1]);

                if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
                {
                    return "OK";
                }
                else
                {
                    return "Invalid Time";
                }
            }

            catch (Exception)
            {
                return "Invalid Time";
            }
        }
    }
}
