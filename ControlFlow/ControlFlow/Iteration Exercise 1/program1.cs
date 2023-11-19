using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Iteration_Exercise_1
{
    internal class program1
    {
        static void Main(string[] args)
        {
            int lowerLimit = 1;
            int upperLimit = 100;
            int counter = 0;


            for (int i = lowerLimit; i <= upperLimit; i++)
            {

                if (i % 3 == 0)
                {
                    counter = counter + 1;
                }

            }


            Console.WriteLine("Between [{0} - {1}] there are {2} values divisible by {3}", lowerLimit, upperLimit, counter, 3);

        }
    }
}
