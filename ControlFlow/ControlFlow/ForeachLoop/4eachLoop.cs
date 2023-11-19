using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.ForeachLoop
{
    internal class _4eachLoop
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 3, 4};

            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }
        }
    }
}
