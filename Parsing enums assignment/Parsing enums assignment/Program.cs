using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_enums_assignment
{
    class Program
    {
        public enum Days
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
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string CurrentDay = Console.ReadLine().ToLower();
                Days day;

                if (Enum.TryParse<Days>(CurrentDay, out day))
                {
                    Console.WriteLine("Good job on knowing the day is " + day);
                    Console.ReadLine();
                }
                else
                {
                    throw new OverflowException();
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
