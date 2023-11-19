using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.WhileLoop
{
    internal class Dowhile
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if (i%2  == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
    }
}
