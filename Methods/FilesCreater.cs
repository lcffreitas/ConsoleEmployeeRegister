using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task2InheritanceAndPolimorphism.Models;

namespace Task2InheritanceAndPolimorphism.Methods
{
    public class FilesCreater
    {
        public static void CreateDirectory()
        {
            string directoryPath = @"C:\Employees";

            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory exist already! The directory was created {0}", Directory.GetCreationTime(directoryPath));
                Console.WriteLine("Creating and updating files...");
                return;
            }

            DirectoryInfo di = Directory.CreateDirectory(directoryPath);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(directoryPath));
        }

        public static void CreateFile()
        {
            string filePath = @"c:\Employees\employees.txt";

            List<string> employeeList = new List<string>();

            foreach (Employee employee in Employee.Employees)
            {
                employeeList.Add(employee.ToString());
            }
            if (File.Exists(filePath))
            {
                File.AppendAllLines(filePath, employeeList);
                Console.WriteLine($"File updated with success at {filePath}.");
            }
            else
            {
                File.WriteAllLines(filePath, employeeList);
                Console.WriteLine("File sucessefully created!");
            }
        }
    }
}