using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_enums_assignment
{
    class Program
    {
        public enum Days //enum for days of the week
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }


        static void Main(string[] args)
        {
            try //wrapping statement in a try/ catch block  and have it print "Please enter an actual day of the week." to the console if an error occurs.
            {
                Console.WriteLine("Please enter the current day of the week: "); //prompt user to enter days of the week.
                string CurrentDay = Console.ReadLine().ToLower();// if user enters capital letters it will be lower
                Days day;

                if (Enum.TryParse<Days>(CurrentDay, out day))
                {
                    Console.WriteLine("Good job on knowing the day is " + day);
                    Console.ReadLine();
                }
                else 
                {
                    throw new OverflowException(); // throw exception if operation produces a result that is outside the range of the data type returned by the operation.
                }
            }
            catch (OverflowException)

            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();    
        }   
            
        

     
    }
}
