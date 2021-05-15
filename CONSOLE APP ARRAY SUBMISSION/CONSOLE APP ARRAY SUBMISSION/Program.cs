using System;
using System.Collections.Generic;

namespace CONSOLE_APP_ARRAY_SUBMISSION
{
    class Program
    {
        static void Main()
        {
            //list of strings

            List<string> strList = new List<string>();
            strList.Add("apple");
            strList.Add("banana");
            strList.Add("pear");
            strList.Add("kiwi");

            Console.WriteLine("Select a number between 0-3 to receive a healthy treat.");
            int fruit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You received an " + strList[fruit] + ".");
            Console.ReadLine();








            //Array of strings

            string[] candyArray = { "licorice", "candy bar", "lollipop", "jelly beans" };
            Console.WriteLine("Select a number between 0-3 to receive a surprise.");
            int surprise = Convert.ToInt32(Console.ReadLine());

            while (surprise < 0 || surprise >= 4)
            {
                Console.WriteLine("You chose a wrong number. Try again.");
                surprise = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("You received " + candyArray[surprise] + "!!!");
            Console.ReadLine();

            //Array of integers

            int[] numArray = { 1, 2, 440, 74, 10 };
            Console.WriteLine("Choose a number between 0-4 to see your lucky number of the day.");
            int luckyNumber = Convert.ToInt32(Console.ReadLine());




            while (luckyNumber < 0 || luckyNumber >= 5)
            {
                Console.WriteLine("You entered an incorrect number. Please enter an number between 0-4");
                luckyNumber = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Your lucky number is: " + numArray[luckyNumber] + "!!!");
            Console.ReadLine();






        }
    }
}
