using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_method_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            math mathNumbers = new math();
            Console.WriteLine("Input two numbers one at a time. You do not need to enter a second number.");
            Console.WriteLine("Input first number; ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathNumbers.AddNumber(input1, input2));
            Console.ReadLine();
            

            



            



        }
    }
}
