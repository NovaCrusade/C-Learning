using System;

namespace Csharpfund
{
    class program
    {
        static void Main(string[] args)
        {
            var fullName = "Man dem";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            var Index = fullName.IndexOf(' ');
            var firstname = fullName.Substring(0, Index);
            var lastname = fullName.Substring(Index + 1);
            Console.WriteLine("Firstname: " + firstname);
            Console.WriteLine("Lastname: " + lastname);

            var names = fullName.Split(' ');
            Console.WriteLine("firstname: " + names[0]);
            Console.WriteLine("lastname: " + names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Pittino"));

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}