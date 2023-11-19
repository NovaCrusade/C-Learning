using System;

namespace Csharpfund
{
    class program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2023, 2, 5);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("hours: " + now.Hour);
            Console.WriteLine("mintues: " + now.Minute);
            
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(2);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("G"));
        }
    }
}
