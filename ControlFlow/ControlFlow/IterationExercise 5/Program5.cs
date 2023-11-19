using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.IterationExercise_5
{
    internal class Program5
    {
        static int CountTinyPairs(int[] a, int[] b, int k)
        {
            int count = 0;
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                int concatenated = int.Parse(a[i].ToString() + b[n - 1 - i].ToString());

                if (concatenated < k)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] a = { 34, 35, 51, 49 };
            int[] b = { 53, 32, 43, 47 };
            int k = 70;

            int result = CountTinyPairs(a, b, k);
            Console.WriteLine(result);  // Output: 5
        }
    }
}
