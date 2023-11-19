using System;

namespace ControlFlow
{
    class program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12) 
            {
                Console.WriteLine("it's morning");
            }
            else if (hour >= 12 && hour < 18) 
            {
                Console.WriteLine("it's the aftenoon");
            }
            else
                Console.WriteLine("it's evening");
        }
    }
}