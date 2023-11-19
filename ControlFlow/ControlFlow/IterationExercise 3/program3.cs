using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.IterationExercise_3
{
    internal class program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number and get the factorial of it");

            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;



            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}! : {1}", number, factorial);
        }
    }
}
