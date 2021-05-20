using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_method_2
{
    class void_Method
    {
        
        
            public void void1(int number1)
            {
                int total = number1 / 2;
                Console.WriteLine(total);

            }
            public void void1(int number1,out int number2)// method with output parameters/ Overload a method
            {
                int total = number1 + 5;
                number2 = total;
                Console.WriteLine(total);
            }

            

    }
}
