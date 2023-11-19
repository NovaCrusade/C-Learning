using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder.ExecriseText
{
    internal class program5
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter an English word:");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

        static int CountVowels(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return 0;
            }

            // Convert the word to lowercase to make the check case-insensitive
            word = word.ToLower();

            int count = 0;

            foreach (char c in word)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsVowel(char c)
        {
            // Check if the character is a vowel (a, e, o, u, i)
            return c == 'a' || c == 'e' || c == 'o' || c == 'u' || c == 'i';
        }
    }
}
