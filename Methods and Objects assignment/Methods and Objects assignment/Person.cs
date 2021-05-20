using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_assignment
{
    public  class Person //Create a class called Person and give it two properties, each of data type string
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() //Give this class a void method called SayName() that takes no parameters
        {
            Console.WriteLine("Name [{0} {1}]", FirstName, LastName);
        }
    }




}
