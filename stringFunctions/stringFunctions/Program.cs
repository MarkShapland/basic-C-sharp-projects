using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The main said, \"Hello\", Jesse. \n \t Hello on a tab";
            ////  escape character \
            //// escape sequence inside stringfor entire string @ everything in between "". example @"c:/users/filename";

            //bool trueOrFalse = name.Contains("s"); //true
            //trueOrFalse = name.EndsWith("s"); //false
            //int length = name.Length; //length of name
            //name.ToUpper(); // converts to uppercase
            //name.ToLower(); // converts to lower
            //// strings are immutable = once created strings can't be changed.

            //StringBuilder sb = new StringBuilder();// string builder, dynamic object throw string into it and expand
            //sb.Append("my name is Jesse;");
            //Console.WriteLine(quote);
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            ;
            string hello = "Hello, ";

            
            string name = "My name is";

            
            string chris = "Chris";

            string fullName = string.Concat(hello, name, chris);
            string paragraph = ("Hello, \n my name \n is Chris.");

            chris.ToUpper();
            Console.WriteLine(paragraph);
            Console.ReadLine();

        }
    }
}
