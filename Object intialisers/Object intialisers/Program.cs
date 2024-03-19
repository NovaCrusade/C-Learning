using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_intialisers
{
    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception) 
            {
                Console.WriteLine("conversion failed");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");
        }

        static void Useparams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 3, 4));
            Console.WriteLine(calculator.Add(1, 3, 4, 6, 7));
            Console.WriteLine(calculator.Add(new int[] { 1, 3, 4 }));
        }

        static void Usepoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(30, 70));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An error ocurred unexpectedly");
            }

        }
    }
}
