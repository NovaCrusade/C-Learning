﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists.List
{
    internal class ListMethod
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4, 5 };
            numbers.Add(1);
            numbers.AddRange(new int[3] {6, 7, 8});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("index of 1 " + numbers.IndexOf(1));
            Console.WriteLine("index of 1 " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
             Console.WriteLine(number); 

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
