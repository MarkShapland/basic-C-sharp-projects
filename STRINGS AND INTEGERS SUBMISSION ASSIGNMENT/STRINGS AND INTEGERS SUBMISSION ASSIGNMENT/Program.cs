using System;
using System.Collections.Generic;


namespace STRINGS_AND_INTEGERS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take user input and divide each number in list
            try
            {
                List<int> num1 = new List<int>();
                num1.Add(2);
                num1.Add(4);
                num1.Add(6);
                num1.Add(8);
                Console.WriteLine("Enter a number to be divided by in the list.");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                foreach (int num in num1)
                {
                    Console.WriteLine(num + " divided by " + num2 + " equals " + num / num2);
                    Console.ReadLine();
                }
                //
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Please divide by zero.");

            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");

            }
            finally
            {
                Console.ReadLine();
                Console.WriteLine(" Block is Executed");
                Console.ReadLine();
            }

        }    
    }
}
