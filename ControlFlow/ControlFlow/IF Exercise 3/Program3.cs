using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Exercise_3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter image width: ");
            var imageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter image height: ");
            var imageHeight = Convert.ToInt32(Console.ReadLine());

            if (imageHeight >= imageWidth)
                Console.WriteLine("Your image is in Portrait mode");
            else
                Console.WriteLine("Your image is in Landscape mode");
        }
    }
}
