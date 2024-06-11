using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2InheritanceAndPolimorphism.Models;

namespace Task2InheritanceAndPolimorphism.Methods
{
    public class EmployeeLister
    {
        public static void ListEmployees()
        {
            foreach (Employee employee in Employee.Employees)
            {
                Console.WriteLine($"{employee.Name} - $ {employee.Payment():F2}");
            }
        }
    }
}
