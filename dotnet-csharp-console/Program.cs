using System;

namespace dotnet_csharp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content of the text file was:");
            Console.WriteLine(System.IO.File.ReadAllText("test.txt"));

            if(args.Length > 0)
            {
                System.IO.File.WriteAllText("test.txt", args[0]);
            }

            Console.WriteLine("Context of the text file is now:");
            Console.WriteLine(System.IO.File.ReadAllText("test.txt"));
        }
    }
}
