using System;

namespace Exercise4_SpeedCameraLogic
{
    /*
     * Your job is to write a program for a speed camera. 
     * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
     * Write a program that asks the user to enter the speed limit. 
     * Once set, the program asks for the speed of a car. 
     * If the user enters a value less than the speed limit, program should display Ok on the console. 
     * If the value is above the speed limit, the program should calculate the number of demerit points. 
     * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
     * If the number of demerit points is above 12, the program should display License Suspended.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Get the speed limit from the user
            Console.WriteLine("Please enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            // Get the car speed from the user
            Console.WriteLine("Please enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            // Determine the difference between the speed of the car and the speed limit
            var speedDifference = carSpeed - speedLimit;

            // Calculate the number of demerit points
            var demeritPoints = (speedDifference <= 0) ? 0 : (int)Math.Ceiling(speedDifference / 5.0);

            // Display result
            if (demeritPoints == 0)
            {
                Console.WriteLine("OK");
            }
            else if (demeritPoints == 1)
            {
                Console.WriteLine(demeritPoints + " demerit point");
            }
            else if (demeritPoints >= 2 && demeritPoints <= 12)
            {
                Console.WriteLine(demeritPoints + " demerit points");
            }
            else
            {
                Console.WriteLine("License Suspended!");
            }
        }
    }
}
