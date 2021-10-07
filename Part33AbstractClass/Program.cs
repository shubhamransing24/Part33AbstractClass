using System;

namespace Part33AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                id = 101,
                firstName="Shubham",
                lastnName="Ransing",
                annualPay=4000000
                
            };
            fte.Print();
           
            int Annual=fte.AnnualSalary();
            Console.WriteLine(Annual);
            PartTimeEmployee pte = new PartTimeEmployee()
            {
                id=102,
                firstName="Saurabh",
                lastnName="Ransing",
                hourlPay=400,
                totalHours=2020

            };
            pte.Print();
            int part=pte.PartSalary();
            Console.WriteLine(part);
        }
    }
}
