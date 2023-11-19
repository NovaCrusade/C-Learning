using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.ExecriseText
{
    internal class program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour format (e.g., 19:00):");
            string input = Console.ReadLine();

            if (IsValidTime(input))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        static bool IsValidTime(string input)
        {
            // Check if the input is not null or empty
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            // Split the input into hours and minutes
            string[] timeComponents = input.Split(':');

            // Check if there are exactly two components
            if (timeComponents.Length != 2)
            {
                return false;
            }

            // Try parsing hours and minutes
            if (int.TryParse(timeComponents[0], out int hours) && int.TryParse(timeComponents[1], out int minutes))
            {
                // Check if hours and minutes are in the valid range
                return hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59;
            }

            return false;
        }
    }
}
