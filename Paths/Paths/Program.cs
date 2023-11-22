using System;
using System.IO;

namespace CSharpfund
{
    class program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Portfolio\NovaWorks\Self-Taught\C#\C-Learning\StringBuilder\StringBuilder.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extesion: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}