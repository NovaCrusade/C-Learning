using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Exercise_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");            
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1 && number <= 10 ) 
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
