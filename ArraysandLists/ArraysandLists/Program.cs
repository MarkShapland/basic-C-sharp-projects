using System;
using System.Collections.Generic;


namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {

            //lists integer
            List<int> intlist = new List<int>();
            intlist.Add(4);
            intlist.Add(10);
            intlist.Remove(10);
            intlist.Add(5);
            //string list
            List<string> strList = new List<string>();
            strList.Add("mark");

            
            Console.WriteLine(intlist[0]);
            Console.ReadLine();
        //{// Both of these create the same array
        // use array when you have a fixed quantity, storing large quantity of something, 
        //    int[] numArray = new int[5];
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;

        //    int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //    int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //    // how to change index in array
        //    numArray2[5] = 650;
        //    Console.WriteLine(numArray2[5]);
        //    Console.ReadLine();


        }
    }
}
