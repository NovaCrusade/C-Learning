using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.ExecriseText
{
    internal class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by hyphen (-):");
            string input = Console.ReadLine();

            bool areConsecutive = CheckConsecutive(input);

            if (areConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        static bool CheckConsecutive(string input)
        {
            string[] numbers = input.Split('-');

            for (int i = 1; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) != int.Parse(numbers[i - 1]) + 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
