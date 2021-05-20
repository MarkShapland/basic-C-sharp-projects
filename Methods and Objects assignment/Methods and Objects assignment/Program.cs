using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() // instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student
            {
                FirstName = "Sample",
                LastName = "Student"

            };

            person.SayName();
            Console.ReadLine();
                
        }
    }
}
