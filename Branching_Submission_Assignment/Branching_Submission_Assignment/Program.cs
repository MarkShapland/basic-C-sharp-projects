using System;

namespace Branching_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            } 
            else 
            {
                Console.WriteLine("Please enter the dimensions of the package.");
                
            }

            Console.WriteLine("width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensions = width + height + length;
            int product = width * height * length;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                int total = product * weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + total + " Thank you!");
            }


            Console.ReadLine();

        }
    }
}
