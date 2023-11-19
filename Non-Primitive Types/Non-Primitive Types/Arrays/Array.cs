using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_Types.Arrays
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);

            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            string[] names = new string[3] { "Jack", "John", "Mary" };

            
        }
    }
}
