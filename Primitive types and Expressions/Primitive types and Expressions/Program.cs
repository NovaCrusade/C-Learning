using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Variable
{
    class Type
    {
       static void Main(string[] args)
        {
            //ctrl + left click takes you to the object browser on a declaration

            byte number = 2;
            var count = 10;
            float FullPrice = 11f;
            var character = 'a';
            var firstname = "Abdul";
            var isWorking = false;
            const float Pi = 3.14f;
            //conversion
            var num = "1234";
            int i = Convert.ToInt32(num);
            //Operators
            int a = 1; int b = 2;
            
            /*Boolean operators
             & and
             ^ Xor
             | Or
             && Conditional and
             || Conditional or
             ! negation Not
            */
            //Comparsion Operators
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            //Arithmetic Operators
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
           
            // max and min
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(FullPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstname);
            Console.WriteLine(isWorking);
            Console.WriteLine(Pi);
            Console.WriteLine(i);
        }
    }
}