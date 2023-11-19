using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.IterationExercise_4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            for (int j = 0; j < 1; j++)
            {
                Console.WriteLine(rnd.Next(10));
            }
            if (rnd.Next(10) == i)
            {
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
    }
}
