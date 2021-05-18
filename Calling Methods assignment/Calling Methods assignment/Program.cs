using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            // The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

            // In the Main() program, ask the user what number they want to do the math operations on.

            //Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

            Methods math = new Methods();
            Console.WriteLine("Enter a number you would like to have math operations on: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number plus 25 = " + math.mathOperation1(num)); //calls the method and passes the
            Console.WriteLine("Your number times 25 = " + math.mathOperation2(num)); // user input as a parameter
            Console.WriteLine("Your number subtracted by 25 = " + math.mathOperation3(num));
            Console.ReadLine();
        }
    }
}
