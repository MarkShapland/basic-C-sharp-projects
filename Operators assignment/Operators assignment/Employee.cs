using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_assignment
{
    class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            bool example;
            if (employee.ID == employee2.ID)
            {
                example = true;
            }
            else
            {
                example = false;

            }
            return example;

        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            bool example;
            if (employee.ID != employee2.ID)
            {
                example = false;
            }
            else
            {
                example = true;

            }
            return example;
        }

        public override bool Equals(object obj)
        {

            Employee employee = obj as Employee;
            bool example3;

            if (employee == null)
            {
                example3 = false;
            }
            else
            {
                example3 = true;
            }

            return example3;
        }

    }

}
