using System;
using System.IO;
using System.Linq;

namespace AoC_2022_Day03
{
    class Program
    {
        public const string FilePath = @"C:\ZZZ MW Daten\AoC_2022_Day03_Input_Original.txt";

        static void Main(string[] args)
        {            
            var Input = File.ReadAllText(FilePath)
            .Split("\r\n", StringSplitOptions.None)
            .ToArray();

            var Output = Input;




            Console.WriteLine("Anwendung ist responsive");
            Console.ReadKey();
        }
    }
}
