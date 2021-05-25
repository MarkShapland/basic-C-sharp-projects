using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\users\mark_\logs\log.txt.", text); //saves text to the log.txt file

            string path = @"C:\users\mark_\logs\log.txt.";

            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadLine();
        }
    }
}
