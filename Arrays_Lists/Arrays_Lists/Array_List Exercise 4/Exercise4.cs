using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists.Array_List_Exercise_4
{
    internal class Exercise4
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            Console.WriteLine("Enter numbers or type 'Quit' to exit.");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                if (int.TryParse(input, out int number))
                {
                    uniqueNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine("Unique numbers entered:");

            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
