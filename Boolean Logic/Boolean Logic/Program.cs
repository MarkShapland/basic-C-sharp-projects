using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false|| false);

            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(false != true);

            // xor operator
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedTickets = Convert.ToInt32(Console.ReadLine());

            bool qualifies = (age > 15 && !dui && speedTickets < 4);
            Console.WriteLine("Qualified: " + qualifies);
            Console.ReadLine();
        }
    }
}

