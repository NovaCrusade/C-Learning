using System;
using System.IO;

namespace CSharpfund
{
    class program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jjpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\mufile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var context = File.ReadAllText(path);

            var fileinfo = new FileInfo(path);
            FileInfo.CopyTo("...");
            FileInfo.Delete();
            if (fileinfo.Exists)
            {
                //
            }


        }

    }
}