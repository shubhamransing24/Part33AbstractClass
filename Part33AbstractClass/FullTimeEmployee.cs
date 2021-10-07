
using System;
using System.Collections.Generic;
using System.Text;
namespace Part33AbstractClass
{
    class FullTimeEmployee :Employee
    {
    
       // public int monthlyPay { get; set; }
        public int annualPay { get; set; }
        public int AnnualSalary()
        {
            return annualPay / 12;
        }
        public override void Print()
        {
            Console.WriteLine("Full Name={0} {1}", firstName, lastnName);
        }
    }
}
