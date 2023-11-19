using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 4, 5, 7 };

            //length of array
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("effect of clear()");
            foreach (int i in numbers)
                Console.WriteLine(i);

            //copy()
            int[] numbers2 = new int[3]; 
            Array.Copy(numbers, numbers2, 3);

            Console.WriteLine("effect of copy()");
            foreach(int i in numbers2)
                Console.WriteLine(i);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("effect of sort()");
            foreach (int i in numbers)
                Console.WriteLine(i);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("effect of reverse()");
            foreach (int i in numbers)
                Console.WriteLine(i);
        }
    }
}
