using System;
using System.Collections.Generic;
using System.Text;

namespace Part33AbstractClass
{
    class PartTimeEmployee :Employee
    {
    
        public int hourlPay { get; set; }
        public int totalHours{ get; set; }
        public int PartSalary()
        {
            return hourlPay * totalHours;
        }
        public override void Print()
        {
            Console.WriteLine("Full Name={0} {1}", firstName, lastnName);
        }
    }
}
