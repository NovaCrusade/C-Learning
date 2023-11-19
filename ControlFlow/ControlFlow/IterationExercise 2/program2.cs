using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.IterationExercise_2
{
    internal class program2
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Write number or write \"ok\" for exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() != "ok")
                {
                    sum += Convert.ToInt32(input);
                    continue;
                }
                break;
            }
            Console.WriteLine("All sum: " + sum + ".");
        }
        }
    }
