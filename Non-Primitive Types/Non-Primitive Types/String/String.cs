using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_Types.String
{
    internal class String
    {
        static void Main(string[] args)
        {
            string firstname = "Smosh";
            string lastname = "Man";

            string fullname = firstname + " " + lastname;

            string myfullname = string.Format("My full name is {0} {1}", fullname, fullname);
            string[] names = new string[3] { "silver", "gold", "platinum" };
            string formatname = string.Join(", ", names);
            Console.WriteLine(formatname);
        }
    }
}
