using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Switch_Case
{
    internal class SC_statement
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season) 
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It's a deal");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's autumn");
                    break;

                default:
                    Console.WriteLine("No sir");
                    break;
            }
        }
    }
}
