using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists.Array_List_Exercise_5
{
    internal class Exercise5
    {
        static void Main(string[] args)
        {
            while(true)
        {
                Console.Write("Enter a list of comma-separated numbers (e.g., 5,1,9,2,10): ");
                string input = Console.ReadLine();

                string[] numberStrings = input.Split(',');

                if (numberStrings.Length >= 5)
                {
                    if (TryParseNumbers(numberStrings, out int[] numbers))
                    {
                        var sortedNumbers = numbers.OrderBy(n => n).Take(3);
                        Console.WriteLine("Three smallest numbers in the list: " + string.Join(", ", sortedNumbers));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid List: Please enter valid numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid List: The list should include at least 5 numbers.");
                }
            }
        }

        static bool TryParseNumbers(string[] numberStrings, out int[] numbers)
        {
            numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (!int.TryParse(numberStrings[i], out numbers[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
