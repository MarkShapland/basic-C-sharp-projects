using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_comparison
{
    class Program
    {
        static void Main(string[] args)
        {   // do while statement
            //Console.WriteLine("Guess my favorite animal: ");
            //string animal = Console.ReadLine();
            //bool myFavorite = animal == "dog";

            //do
            //{
            //    switch (animal)
            //    {
            //        case "cat":
            //            Console.WriteLine("You guessed cat. Try again.");
            //            Console.WriteLine("Guess my favorite animal: ");
            //            animal = Console.ReadLine();
            //            break;

            //        case "donkey":
            //            Console.WriteLine("You guessed donkey. Try again.");
            //            Console.WriteLine("Guess my favorite animal: ");
            //            animal = Console.ReadLine();
            //            break;

            //        case "bird":
            //            Console.WriteLine("You guessed bird. Try again.");
            //            Console.WriteLine("Guess my favorite animal: ");
            //            animal = Console.ReadLine();
            //            break;

            //        case "dog":
            //            Console.WriteLine("You guessed dog. That is correct.");
            //            myFavorite = true;
            //            break;

            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess my favorite animal: ");
            //            animal = Console.ReadLine();
            //            break;

            //    }

            //}
            //while (!myFavorite);
            //Console.ReadLine();


            //while statement

            Console.WriteLine("which one of these numbers is my favorite: 82, 84, 86, 88, 92");
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool number = input1 == 92;

            while (!number)
            {
                switch (input1)
                {
                    
                    
                    default:
                        Console.WriteLine("Wrong");
                        Console.WriteLine("Try again.");
                        input1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 92:
                        Console.WriteLine("Congratulations you figured it out! Press enter for the next problem.");
                        number = true;
                        break;
                }
                Console.ReadLine();

            }
        }
    }
}
