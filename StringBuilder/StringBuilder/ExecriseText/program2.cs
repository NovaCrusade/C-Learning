using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.ExecriseText
{
    internal class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by hyphen (-):");
            string input = Console.ReadLine();

            // Check if the user pressed Enter without supplying input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided. Exiting...");
                return;
            }

            bool hasDuplicates = CheckForDuplicates(input);

            if (hasDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                Console.WriteLine("No Duplicates");
            }
        }

        static bool CheckForDuplicates(string input)
        {
            string[] numbers = input.Split('-');

            // Convert the string array to an integer array
            int[] intArray = numbers.Select(int.Parse).ToArray();

            // Use LINQ to check for duplicates
            bool hasDuplicates = intArray.Length != intArray.Distinct().Count();

            return hasDuplicates;
        }
    }
}
