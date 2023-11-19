using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_Types.Enum
{
    public enum Shipping
    {
        Standardmail = 1,
        Registeredmail = 2,
        Expressmail = 3
    }
    internal class Enum
    {
        static void Main(string[] args)
        {
            //convert enums to and from int
            var method = Shipping.Expressmail;
            Console.WriteLine((int)method);

            int methodID = 3;  
            Console.WriteLine((Shipping)methodID);

            //convert to string and back to enum
            Console.WriteLine(method.ToString());

            var methodName = "Expressmail";
            var shippingMethod = (Shipping) Enum.Parse(typeof(Shipping), methodName);
        }
    }
}
