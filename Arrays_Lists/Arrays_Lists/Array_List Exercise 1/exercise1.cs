using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays_Lists.Array_List_Exercise_1
{
    internal class exercise1
    {
        static void Main()
        {
            List<string> likes = new List<string>();

            while (true)
            {
                Console.Write("Enter a name (press Enter to finish): ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                    break;

                likes.Add(input);
            }

            int numberOfLikes = likes.Count;

            if (numberOfLikes == 0)
            {
                Console.WriteLine("No one likes your post.");
            }
            else if (numberOfLikes == 1)
            {
                Console.WriteLine($"{likes[0]} likes your post.");
            }
            else if (numberOfLikes == 2)
            {
                Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
            }
            else
            {
                int numberOfOthers = numberOfLikes - 2;
                Console.Write($"{likes[0]}, {likes[1]}, and {numberOfOthers} others like your post.");
            }
        }
    }
    
}
    

