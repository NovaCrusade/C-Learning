using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_Types.Reftype_Valuetype
{
    internal class RefValue
    {
        static void Main(string[] args)
        {
            var a = 1; 
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array = new int[3] {1, 2, 3};
            var array2 = array;
            array2[0] = 0;
            Console.WriteLine(string.Format("array[0]: {0}, array2[0]: {1}", array[0], array2[0]));
        }
    }
}
