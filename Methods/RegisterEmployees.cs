using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2InheritanceAndPolimorphism.Models;

namespace Task2InheritanceAndPolimorphism.Methods
{
    public class RegisterEmployees
    {
        public static void AddEmployee()
        {
            bool condition = true;

            string filePath = @"c:\Employees\employees.txt";

            if (File.Exists(filePath))
            { 
            Verification.IdVerification();
            }

            int updatedId = Verification.maxId;

            while (condition) 
            {
                
                bool isOutsourced = false;
                bool askingIfOutsourced = true;
                while (askingIfOutsourced)
                {
                    Console.Write("Is an outsourced employee? (Y/N) ");
                    string isOutsourcedAnswer = Console.ReadLine().ToUpper().Trim();
                    if (isOutsourcedAnswer == "Y")
                    {
                        isOutsourced = true;
                        askingIfOutsourced = false;
                    }
                    else if (isOutsourcedAnswer == "N")
                    {
                        isOutsourced = false;
                        askingIfOutsourced = false;
                    }
                    else
                    {
                        Console.WriteLine("Unexpected answer!");
                    }
                }
                

                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Hours worked: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (isOutsourced)
                {
                    Console.Write("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee.Employees.Add(new OutsourcedEmployee(updatedId, name,hours,valuePerHour,additionalCharge));
                }
                else
                {
                    Employee.Employees.Add(new Employee(updatedId, name,hours,valuePerHour));
                }
                bool askingIfAddMore = true;
                while (askingIfAddMore)
                {
                    Console.Write("Do you want to add more? (Y/N): ");
                    string addMoreAnswer = Console.ReadLine().ToUpper().Trim();
                    if (addMoreAnswer == "Y")
                    {
                        condition = true;
                        askingIfAddMore = false;
                        updatedId++;
                        Verification.maxId = updatedId;
                    } 
                    else if (addMoreAnswer == "N")
                    {
                        condition = false;
                        askingIfAddMore= false;
                    }else
                    {
                        Console.WriteLine("Unexpected answer!");
                    }
                }

            }
        }
    }
}
