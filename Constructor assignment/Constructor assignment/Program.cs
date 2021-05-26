using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Constructor_assignment
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will test you for car hoarding behavior. How many cars do you own?");

            var OwnedCars = Convert.ToInt32(Console.ReadLine());
            CarCount Count = new CarCount(OwnedCars);

            Console.WriteLine("How many total cars do you desire?");
            var DesiredCars = Convert.ToInt32(Console.ReadLine()); 

            const string problem = "You have a car problem!"; //Create a const variable.
            var result = Count.Hoarder(OwnedCars, DesiredCars); //Create a variable using the keyword “var.”

            Console.WriteLine("Hoarder Status: " + result);

            if (result == true)
            {
                Console.Write(problem + " I wish I had your problem.");
            }
            
                  
            Console.Read();
        }

    }

}

