using System;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 1, 11));
            Console.WriteLine(person.Age);
        }
    }
}
