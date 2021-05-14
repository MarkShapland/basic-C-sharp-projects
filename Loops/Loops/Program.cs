using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch statements
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = number == 12;
            do
            {

                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again." +
                            "");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed);
           
            Console.ReadLine();
        }
    }
}
