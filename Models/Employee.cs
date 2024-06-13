using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2InheritanceAndPolimorphism.Methods;

namespace Task2InheritanceAndPolimorphism.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public bool IsOutsourced { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public static List<Employee> Employees { get; set; }  = new List<Employee>();

        public Employee(int id, string name, int hours, double valuePerHour) 
        {
            Id = Verification.maxId;
            IsOutsourced = false;
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment ()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"Id:{Id} | Name: {Name} | Hours: {Hours} | Value per Hour: ${ValuePerHour} | Is Outsourced: {IsOutsourced} | Payment: ${Payment()}";
        }
    }
}
