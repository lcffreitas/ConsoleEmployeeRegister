using System.ComponentModel;
using Task2InheritanceAndPolimorphism.Methods;
using Task2InheritanceAndPolimorphism.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        RegisterEmployees.AddEmployee();
        EmployeeLister.ListEmployees();
    }
}