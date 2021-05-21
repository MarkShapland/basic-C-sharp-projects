using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee>()
            {    //List with 10 employees
            new Employee() { FirstName = "Mark", LastName = "Smithe", Id = 1 },
            new Employee() { FirstName = "Joe", LastName = "Lawrence", Id = 2 },
            new Employee() { FirstName = "Joe", LastName = "Shmoe", Id = 3 },
            new Employee() { FirstName = "James", LastName = "Onetooth", Id = 4 },
            new Employee() { FirstName = "Mike", LastName = "Rocks", Id = 5 },
            new Employee() { FirstName = "Mary", LastName = "Scary", Id = 6 },
            new Employee() { FirstName = "Melissa", LastName = "Bossy", Id = 7 },
            new Employee() { FirstName = "Christine", LastName = "worker", Id = 8 },
            new Employee() { FirstName = "Lawrence", LastName = "Punch", Id = 9 },
            new Employee() { FirstName = "Jimmy", LastName = "Goldtooth", Id = 10 },
            };

            List<Employee> Person = new List<Employee>(); // Using a foreach loop, create a new list of all employees with the first name “Joe”.
            foreach (Employee name in Employee)
            {
                if (name.FirstName == "Joe")
                {
                    Person.Add(name);
                    Console.WriteLine(name.FirstName);

                }
            }
            List<Employee> Person2 = new List<Employee>();
            Person2 = Employee.Where(x => x.FirstName == "Joe").ToList(); //Using a Lambda expression, create a new list of all employees with the first name “Joe”.
            foreach (Employee person in Person2)
            {

                Console.WriteLine(person.FirstName);
            }

            List<Employee> Person3 = new List<Employee>(); //using a lambda expression, make a list of all employees with an Id number greater than 5.
            Person3 = Employee.Where(x => x.Id > 5).ToList();
            foreach (Employee person in Person3)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Id);
            }
            Console.ReadLine();

        }
       
    }
}
