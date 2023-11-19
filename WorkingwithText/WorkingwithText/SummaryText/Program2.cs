using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingwithText.SummaryText
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            var sentence = "THIS text is Long long long long long long long long long long";
            const int Maxlength = 100;

            if (sentence.Length < Maxlength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > Maxlength)
                        break;
                }

                var summary = string.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            } 
        }
    }
}
