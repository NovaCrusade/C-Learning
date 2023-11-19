using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists.Array_List_Exercise_2
{
    internal class exercise2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var Name = Console.ReadLine();

            char[] nameArray = Name.ToCharArray();
            Array.Reverse(nameArray);
            string reverseName = new string(nameArray);

            Console.WriteLine(reverseName);
        }
    }
}
