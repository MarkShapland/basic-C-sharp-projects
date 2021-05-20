using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Mark";
            example.LastName = "Jones";
            example.ID = 1;

            Employee example2 = new Employee();
            example2.FirstName = "James";
            example2.LastName = "Madison";
            example2.ID = 2;

            Employee example3 = new Employee();
            example3.FirstName = "Roger";
            example3.LastName = "Rabbit";
            example3.ID = 3;


            List<Employee> EmployeeList = new List<Employee>() { example, example3, example2 };
            List<Employee> EmployeeList2 = new List<Employee>() { example, example3, example2 };

            foreach (Employee employee1 in EmployeeList)
            {
                foreach (Employee employee2 in EmployeeList2)
                {

                    bool compare = employee1.ID == employee2.ID;
                    if (compare)
                    {
                        Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " And " + employee2.FirstName + " " + employee2.LastName + " have the same ID.");
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
