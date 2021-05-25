using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATETIME_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of DateTime class
            //and, initializing it with the current time 
            //using "Now" 
            DateTime dt1 = DateTime.Now;
            Console.Write(dt1); //Prints the current date and time to the console.
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            int dt2 = Convert.ToInt32(Console.ReadLine());

            DateTime dt3 = dt1.AddHours(dt2);
            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2
            Console.WriteLine("Here is the current time plus {0} hrs.", dt3); 
            Console.ReadLine();
            

            

        }
    }
}
