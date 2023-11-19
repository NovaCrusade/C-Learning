using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringBuilder.ExecriseText
{
    internal class program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words separated by a space:");
            string input = Console.ReadLine();

            string pascalCaseVariable = ConvertToPascalCase(input);

            Console.WriteLine($"PascalCase Variable: {pascalCaseVariable}");
        }

        static string ConvertToPascalCase(string input)
        {
            // Check if the input is not null or empty
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            string[] words = input.Split(' ');

            StringBuilder pascalCaseBuilder = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    // Capitalize the first letter of each word
                    pascalCaseBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word.ToLower()));
                }
            }

            return pascalCaseBuilder.ToString();
        }
    }
}
