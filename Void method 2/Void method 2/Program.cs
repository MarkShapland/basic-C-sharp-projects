using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_method_2
{
    class Program
    {
        static void Main(string[] args)
             
        {
            void_Method void2 = new void_Method();
            Console.WriteLine("please enter a number to be divided by 2: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();
            try
            {
                void2.void1(userInput);// calls first method
                void2.void1(userInput, out userInput);// calls 
                @static.staticClass.concatenate(username);    

            }
            finally
            {
                Console.ReadLine();
            }
        }   
    
    }
}
