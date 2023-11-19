using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Exercise_4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Speed the car was going at: ");
            int Speedlim = Convert.ToInt32(Console.ReadLine());

            int Demerit = (Speedlim * 5) / 60;

            if (Speedlim <= 20)
            {
                Console.WriteLine("Acceptable speed");
            }
            else if (Speedlim >= 20 && Demerit < 12)
            {
                Console.WriteLine("You have: " + Demerit + " points");
            }
            else if (Demerit >= 12)
            {
                Console.WriteLine("License Suspended");
            }

        }
    }
}
