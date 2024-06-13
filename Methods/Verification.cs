using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2InheritanceAndPolimorphism.Models;

namespace Task2InheritanceAndPolimorphism.Methods
{
    public class Verification
    {
        public static int maxId {  get; set; } = 0;
        public static void IdVerification()
        {
            string filePath = @"c:\Employees\employees.txt";
            var lines = File.ReadAllLines(filePath);

            if (File.Exists(filePath))
            {
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    foreach (var part in parts)
                    {
                        if (part.Trim().StartsWith("Id"))
                        {
                            var id = int.Parse(part.Split(':')[1].Trim());
                            if (id >= maxId)
                            {
                                maxId = id;
                                maxId++;
                            }
                        }
                    }
                }
            }
        }
    }
}
