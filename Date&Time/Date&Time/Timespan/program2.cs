﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time.Timespan
{
    internal class program2
    {
        static void Main(string[] args)
        {
            // creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = new TimeSpan(1, 0, 0);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            //add
            Console.WriteLine("add" + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("substract" + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Tostring
            Console.WriteLine("string" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
