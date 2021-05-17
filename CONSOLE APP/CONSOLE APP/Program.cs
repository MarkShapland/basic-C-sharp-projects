using System;
using System.Collections.Generic;


namespace CONSOLE_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            ////One dimensional array
            ////Create loop that adds each user text to the string
            //string[] fruit = new string[4];

            //for (int i = 0; i < 4; i++) //for each text enter, it will increment by 1, adding to listwords 
            //{
            //    Console.WriteLine("Enter the name of a fruit:");

            //    fruit[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Here are the fruits you entered: ");

            //foreach (string i in fruit)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            ////Infinite Loop

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("infinite loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 
            //}

            ////Fix infinite loop to execute
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Fix loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 until 5
            //}
            //Console.ReadLine();

            ////Continue to iterate until a < operator is reached. Stops at int 4
            //int j = 0;
            //while (j < 10)
            //{
            //    Console.WriteLine("The program has reached the < operator " + j);
            //    j++;
            //}
            //Console.ReadLine();


            ////Continue to iterate until a <= operator is reached. Stops at int 5
            //int x = 0;
            //while (x <= 5)
            //{
            //    Console.WriteLine("The program has reached the <= operator " + x);
            //    x++;
            //}
            //Console.ReadLine();

            //// list of strings where each item in the list is unique.
            //List<string> cars = new List<string>() { "ford", "toyota", "subaru", "volvo", "chevy" };
            //Console.WriteLine("Enter a brand of car to search.");
            //string input = Console.ReadLine();
            //bool records = false;
            //foreach (string i in cars)
            //{
            //    if (input == i)
            //    {
            //        Console.WriteLine("You got an index of: " + cars.IndexOf(i)); //loop that iterates through the list and then displays the index of the list that contains matching text on the screen
            //         records = true;
            //        break; //code to the loop that stops it from executing once a match has been found
            //    }
            //    if (!records)
            //    {
            //        Console.WriteLine("Your brand doesn't exist in the list of cars.");//loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //    }
            //}
            //Console.ReadLine();

            ////list of strings that has at least two identical strings in the list.
            //List<string> cars1 = new List<string>() { "ford", "toyota", "subaru", "volvo", "chevy", "chevy" };
            //Console.WriteLine("Enter a brand of car to search.");
            //string input1 = Console.ReadLine();
            //bool records1 = false;

            // for (int c = 0; c < 6; c++)
            //{
            //    if (cars1[c] == input1)
            //    {
            //        Console.WriteLine("You got an index of: " + c); //loop that iterates through the list and then displays the index of the list that contains matching text on the screen
            //        records1 = true;
            //    }
            //    if (!records1)
            //    {
            //        Console.WriteLine("Your brand doesn't exist in the list  of cars.");
            //    }
            //}
            //Console.ReadLine();

            ////list of strings that has at least two identical strings in the list
            //List<string> cars1 = new List<string>() { "ford", "toyota", "subaru", "volvo", "chevy", "chevy" };
            //List<string> cars3 = new List<string>() { };
            // foreach (string d in cars1)
            //{
            //    if (cars3.Contains(d))
            //    {
            //        Console.WriteLine("This brand already appears in the list: " + d);
                    

            //    }

            //    else
            //    {
            //        cars3.Add(d);
            //        Console.WriteLine("This brand has not already appereared in list: " + d);
            //    }
                

            //}

            //Console.ReadLine();
        }
        
    }
}
