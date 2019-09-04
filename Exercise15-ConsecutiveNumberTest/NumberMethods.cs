using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15_ConsecutiveNumberTest
{
    public class NumberMethods
    {
        public static bool consecutiveNumbers(string[] numbers, string direction = "increasing")
        {
            // Set Counter
            var count = 0;

            // Set first number
            var firstNumber = Convert.ToInt32(numbers[0]);

            if (direction == "decreasing")
            {
                foreach (var number in numbers)
                {
                    if (Convert.ToInt32(number) != firstNumber - count)
                    {
                        return false;
                    }

                    count++;
                }
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (Convert.ToInt32(number) != firstNumber + count)
                    {
                        return false;
                    }

                    count++;
                }
            }

            return true;
        }
    }
}
