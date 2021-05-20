using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable name2 = new Employee();
            name2.Quit();

            Employee Name1 = new Employee();
            Name1.FirstName = "Sample";
            Name1.LastName = "Student";
            Name1.SayName();
            
            
            Console.ReadLine();


        }
    }
}
