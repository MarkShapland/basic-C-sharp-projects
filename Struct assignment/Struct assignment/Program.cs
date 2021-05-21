using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 5.2m;
            Console.WriteLine(num1.Amount);
            Console.ReadLine();

        }
    }
}
