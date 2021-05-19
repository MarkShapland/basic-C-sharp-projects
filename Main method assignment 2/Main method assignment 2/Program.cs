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
            math mathNumbers = new math(); //Instantiate the class object
            Console.WriteLine("Input two numbers one at a time. ");
            Console.WriteLine("Input first number; ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number (optional): ");

            int total; //declare in main in order for "total" to be recognized in context
            var validInPut = int.TryParse(Console.ReadLine(), out int input2); 

            if (validInPut)
            {
                total = math.AddNumber(input1, input2);
            }
            else
            {
                total = math.AddNumber(input1);
            }

            Console.WriteLine("Your total is: " + total);
            Console.ReadLine();
            

            



            



        }
    }
}
