using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method__assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            math Numbers = new math();// created a new instance
            Console.WriteLine("Passing an integer 10 and multiplying by 25. ");
            Console.WriteLine(Numbers.Number(10)); //calling a method by using class, method name, parameters.
            Console.WriteLine("Passing in a decimal 10.5 and adding 25. ");
            Console.WriteLine(Numbers.Number(10.5m));
            Console.WriteLine("passing in a string \"20\" that is divided by 10 and will return the result as an integer. ");
            Console.WriteLine(Numbers.Number("20"));
            Console.ReadLine();                                       
        }
    }
}
