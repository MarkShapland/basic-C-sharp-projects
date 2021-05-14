using System;

namespace Tenerary_operator_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 7;
            //int num2 = 16;

            //string result = num1 > num2 ? "num1 is greater than num2." : "num2 is greater than num1.";
            //Console.WriteLine(result);
            //Console.ReadLine();
            //Ternary operator
            //int currentTemperature = 80;

            //int roomTemperature = 70;

            //string comparisonResults = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResults);
            //Console.ReadLine();
            //Branching
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");

            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}

            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");

            //    int roomTemperature = 70;

            //    Console.WriteLine("Hi, What is your name?");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Hi, " + name + "what is the temperature where you are?");
            //    int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //           if (currentTemperature == roomTemperature)
            //        {
            //        Console.WriteLine("It is exactly room temperature.");
            //    }
            //           else if (currentTemperature > roomTemperature)
            //    {
            //        Console.WriteLine("It is warmer than room temperature.");
            //    }
            //           else if ( roomTemperature > currentTemperature)
            //    {
            //        Console.WriteLine("It is colder than room temperature.");
            //    }

            //           else
            //    {
            //        Console.WriteLine("Uhhhh....something went wrong.");
            //    }
            //    Console.ReadLine();
            //ternary operator
            Console.WriteLine("What is your favorite number");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
