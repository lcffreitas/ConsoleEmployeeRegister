using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2InheritanceAndPolimorphism.Models
{
    public class OutsourcedEmployee : Employee
    {
        public OutsourcedEmployee(int id, string name, int hours, double valuePerHour, double additionalCharge) : base(id, name, hours, valuePerHour)
        {
            IsOutsourced = true;
            AdditionalCharge = additionalCharge;
        }

        public double AdditionalCharge { get; set; }

        public override double Payment()
        {
            return (base.Payment() + AdditionalCharge) * 1.16;
        }
    }
}
