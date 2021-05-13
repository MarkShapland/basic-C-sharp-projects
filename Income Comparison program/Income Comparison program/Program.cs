using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_program
{
    class Program
    {
        static void Main()
        {
            //Person 1
            Console.WriteLine( "Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is Person1's hourly rate?");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours does Person1 work per week?");
            int userinput2 = Convert.ToInt32(Console.ReadLine());

            //Person 2
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 2:");
            Console.WriteLine("What is Person2's hourly rate?");
            int userinput3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours does Person 2 work per week?");
            int userinput4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The annual salary of Person 1 is :");
            int income1 = userinput * userinput2 * 52;
            Console.WriteLine(income1);
            Console.WriteLine("The annual salary of Person 2 is :");
            int income2 = userinput3 * userinput4 * 52;
            Console.WriteLine(income2);

            //Boolean check
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = income1;
            int person2 = income2;
            bool value = person1 > person2;
            Console.WriteLine(value);
            Console.ReadLine();


        }
    }
}
